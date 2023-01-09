using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Estudiante
    {
        public string nombre { get; set; }
        public List<string> calificaciones { get; set; }
        public List<string> cursando { get; set; }
        public int creditosActuales { get; set; }

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
            calificaciones = new List<string>();
            cursando = new List<string>();
            creditosActuales = 0;
        }

        public List<string> Inscribir(Asignatura asignatura)
        {
            string materia = asignatura.nombre.ToString();
            if (!cursando.Contains(materia))
            {
                cursando.Add(materia);
                return cursando;
            }
            else
            {
                throw new Exception("Asignatura ya inscrita");
            }
        }

        public List<string> Retirar(Asignatura asignatura)
        {
            string materia = asignatura.nombre.ToString();
            var itemToRemove = cursando.Single(r => r.Equals(materia));
            cursando.Remove(itemToRemove);
            return cursando;
        }

        public static bool Pasar(Calificacion calificacion)
        {
            string calificaciones = calificacion.nota.ToString();
     
           
            if (float.Parse(calificaciones) > 69)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
