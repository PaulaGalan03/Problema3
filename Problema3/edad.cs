using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class edad
    {
        //año nacimiento
        //año actual 2020
        int año_nacimiento;
        int año_actual;
        public edad()
        {
            // edad
            año_nacimiento = 0;
            año_actual = 0;
        }
        public edad(int x, int y)
        {
            // calificación final
            año_nacimiento = x;
            año_actual = y;
        }
        // otros métodos 
        // calificación final

        public void setaño_nacimiento(int x)
        {
            año_nacimiento = x;
        }
        public void setaño_actual(int y)
        {
            año_actual = y;
        }
        public int getaño_nacimiento()
        {
            return año_nacimiento;
        }
        public int getaño_actual()
        {
            return año_actual;
        }
        // calcular edad
        public int calcularedad(int x, int y)
        {
            int edad;
            edad = año_actual-año_nacimiento;
            return edad;
        }

    }
}
