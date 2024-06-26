using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class porcentaje
    {
        //porcentaje conductores menores de 30 años
        //edad
      

        int edad;
        int n;
        public porcentaje()
        {
            // edad
            edad = 0;
            n = 0;
        }
        public porcentaje(int v, int w)
        {
            // calificación final
            edad = v;
            n = w;
        }
        // otros métodos 
        // calificación final

        public void setedad(int v)
        {
            edad = v;
        }
        public void setn(int w)
        {
            n = w;
        }
        public int getedad()
        {
            return edad;
        }
    
    public int getn()
    {
        return n;
    }
        // calcular porcentaje
        public int calcularedad(int v, int w)
        {
            int porcentaje;
            porcentaje = (v *100)/w;
            return porcentaje;
        }

    }
}
