using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Calificacion
    {
        public float nota { get; set; }

       public Calificacion(float nota)
        {
            this.nota = nota;
        }

        public static bool MargenDeNotas(float nota)
        {
            if (nota < 0 || nota > 100)
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
