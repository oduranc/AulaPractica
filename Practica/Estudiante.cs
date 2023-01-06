using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Estudiante
    {
        public string carrera { get; set; }
        public List<string> calificaciones { get; set; }
        public List<string> cursando { get; set; }
        public int creditosActuales { get; set; }

        public Estudiante(string carrera)
        {
            this.carrera = carrera;
            this.calificaciones = new List<string>();
            this.cursando = new List<string>();
            this.creditosActuales = 0;
        }

        public List<string> Inscribir(string asignatura)
        {
            if (!cursando.Contains(asignatura))
            {
                cursando.Add(asignatura);
                return cursando;
            }
            else
            {
                throw new Exception("Asignatura ya inscrita");
            }
        }

        public List<string> Retirar(string asignatura)
        {
            var itemToRemove = cursando.Single(r => r.Equals(asignatura));
            cursando.Remove(itemToRemove);
            return cursando;
        }

        public static bool Pasar(float calificacion)
        {
            if (calificacion > 69)
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
