using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Profesor
    {
        public List<string> impartiendo { get; set; }

        public Profesor()
        {
            impartiendo = new List<string>();
        }

        public List<string> Inscribir(string asignatura)
        {
            if (!impartiendo.Contains(asignatura))
            {
                impartiendo.Add(asignatura);
                return impartiendo;
            }
            else
            {
                throw new Exception("Asignatura ya inscrita");
            }
        }
    }
}
