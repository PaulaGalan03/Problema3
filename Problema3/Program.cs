using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cometarios
            //Creado por: Paula Tatiana Galán Cely
            //Programa: Ingenieria de sistemas
            //Grupo: 47
            //Problema elegido No 3
            //Estructuras usadas for, if-else, contador
            
            //Datos
            //n=numero de registros que se desean hacer
            //f=for
            //fecha
            //Años
            //Sexo
            //registro carro
            //porcentaje

            //Variables
            int años, n, f, porcentaje;
            int conductorm = 0;
            int conductorf = 0;
            int conductor30 = 0;
            int conductorr = 0;
            string linea, sexo, registro;
            int fecha = 0;


            //edad
            edad edad1;
            edad1 = new edad();

            //porcentaje
            porcentaje1 porc1;
            porc1 = new porcentaje1();

            //sexo
            porcentaje2 porc2;
            porc2 = new porcentaje2();

            //registro
            porcentaje3 porc3;
            porc3 = new porcentaje3();
            
            //Mensaje de entrada 
            Console.WriteLine("Bienvenido al programa; por favor ingrese los datos ");

            //Capturar el numero de accidentes que desea calcular
            Console.Write("Ingrese el número de accidentes que desea calcular:");
                linea = Console.ReadLine();
                n = int.Parse(linea);

            //Inicio del ciclo

                for (f = 1; f <= n; f++)
                {
                    //Capturar la fecha de nacimiento del conductor
                    Console.WriteLine("Ingrese el año de nacimiento del conductor: ");
                    linea = Console.ReadLine();
                    fecha = int.Parse(linea);

                    //Capturar el sexo del conductor
                    Console.WriteLine("(F) Femenino");
                    Console.WriteLine("(M) Masculino");
                    Console.WriteLine(" Ingrese el sexo del conductor: ");
                    sexo = string.Concat(Console.ReadLine());

                    //Capturar el registro del carro
                    Console.WriteLine("Donde fue registrado el auto: ");
                    registro = string.Concat(Console.ReadLine());

                    //Calcular años del conductor
                    edad1.setaño_actual(2020);
                    edad1.setaño_nacimiento(fecha);
                    años = edad1.calcularedad(edad1.getaño_actual(), edad1.getaño_nacimiento());
                    Console.WriteLine("\n Edad: " + años);
                
                    //Calcular edades <30
                    if (años < 30)
                    {
                        //Contar
                        conductor30 = conductor30 + 1;

                        //Calcular porcentaje de conductores menores de 30 años.
                        porc1.setedad(conductor30);
                        porc1.setn(n);
                        porcentaje = porc1.calcularedad(porc1.getedad(), porc1.getn());
                        //Mostrar
                        Console.WriteLine("\n El porcentaje de conductores menores de 30 años es: " + porcentaje + "%");
                    }
                    //calcular porcentaje de conductores del sexo masculino y femenino.
                    if (sexo == "F")
                    {
                        
                        //Contar
                        conductorf = conductorf + 1;
                        //Calcular porcentaje de conductores sexo femenino
                        porc2.setsexo(conductorf);
                        porc2.setn(n);
                        porcentaje = porc2.calcularporcentajesexo(porc2.getsexo(), porc2.getn());
                        //Mostrar
                        Console.WriteLine("\n El porcentaje de conductores del sexo femenino es: " + porcentaje + "%");
                    }
                    if (sexo == "M")
                    {
                        
                        //Contar
                        conductorm = conductorm + 1;
                        //Calcular porcentaje de conductores sexo masculino
                        porc2.setsexo(conductorm);
                        porc2.setn(n);
                        porcentaje = porc2.calcularporcentajesexo(porc2.getsexo(), porc2.getn());

                        //Mostrar
                        Console.WriteLine("\n El porcentaje de conductores del sexo masculino es: " + porcentaje + "%");
                    }
                    // Porcentaje de conductores masculinos con edades entre 12 y 30 años.
                    if (sexo == "M" )
                {
                    if (años >= 12 && años <= 30)
                    {
                        //Contar
                        conductorm = conductorm ++;

                        //Calcular porcentaje

                        porcentaje = (conductorm * 100) / n;
                        //Mostrar
                        Console.WriteLine("\n El porcentaje de conductores masculinos con edades entre 12 y 30 años es: " + porcentaje + "%");
                    }
                }
                    

                    // Porcentaje de conductores cuyos carros están registrados fuera de Bogotá.
                    if (registro == "Bogota")
                    {
                    //Mostrar
                    Console.WriteLine("Auto registrado en Bogota");
                }
                else 
                {
                    //Contar
                    conductorr = conductorr + 1;
                    //Calcular porcentaje
                    porc3.setregistro(conductorr);
                    porc3.setn(n);
                    porcentaje = porc1.calcularedad(porc3.getregistro(), porc3.getn());
                    //Mostrar
                    Console.WriteLine("Auto registrado fuera de Bogota:" + porcentaje + "%");
                }
                    
                }
                
            Console.ReadKey();
        }
    }
}
