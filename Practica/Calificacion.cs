using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Calificacion
    {
        public static bool MargenDeNotas(float calificacion)
        {
            if (calificacion < 0 || calificacion > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
