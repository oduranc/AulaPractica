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
        public string nombreDocente { get; set; }

        public Profesor(string nombreDocente)
        {
            this.nombreDocente = nombreDocente;
            impartiendo = new List<string>();
        }
        
        



        public List<string> Inscribir(Asignatura asignatura)
        {
    
           string materia = asignatura.nombre.ToString();
            if (!impartiendo.Contains(materia))
            {
                impartiendo.Add(materia);
                return impartiendo;
            }
            else
            {
                throw new Exception("Asignatura ya inscrita");
            }
        }
    }
}
