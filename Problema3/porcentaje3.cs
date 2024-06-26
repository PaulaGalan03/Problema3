using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class porcentaje3
    {
        //Porcentaje de conductores cuyos carros están registrados fuera de Bogotá.
        int registro;
        int n;

        public porcentaje3()
        {
            // edad
            registro = 0;
            n = 0;
        }
        public porcentaje3(int p, int q)
        {
            // calificación final
            registro= p;
            n = q;
        }
        // otros métodos 
        // calificación final

        public void setregistro(int p)
        {
            registro = p;
        }
        public void setn(int q)
        {
            n = q;
        }
        public int getregistro()
        {
            return registro;
        }

        public int getn()
        {
            return n;
        }
        // calcular porcentaje registro

        public int calcularporcentajesexo(int p, int q)
        {
            int porcentaje;
            porcentaje = (p * 100) / q;
            return porcentaje;
        }
    }
}
