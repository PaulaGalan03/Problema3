using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class porcentaje2
    {
        //Porcentaje de conductores del sexo masculino y femenino.
        //sexo
        int sexo;
        int n;
        public porcentaje2()
        {
            // edad
            sexo = 0;
            n = 0;
        }
        public porcentaje2(int s, int t)
        {
            // calificación final
            sexo = s;
            n = t;
        }
        // otros métodos 
        // calificación final

        public void setsexo(int s)
        {
            sexo = s;
        }
        public void setn(int t)
        {
            n = t;
        }
        public int getsexo()
        {
            return sexo;
        }

        public int getn()
        {
            return n;
        }
        // calcular porcentaje sexo f y m

        public int calcularporcentajesexo(int s, int t)
        {
            int porcentaje;
            porcentaje = (s * 100) / t;
            return porcentaje;
        }
    }
}
