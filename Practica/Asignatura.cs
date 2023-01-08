using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Asignatura
    {
        public string nombre { get; set; }
        public List<string> profesores { get; set; }
        public List<string> estudiantes { get; set; }
        public int creditos { get; set; }
        public Asignatura()
        {
          
            this.profesores = new List<string>();
            this.estudiantes = new List<string>();
            this.creditos = 0;
        }

        public  List<string> Cantidad_De_profesores(List<string> profesores)
        {
            if (profesores.Count() == 0)
            {
                throw new Exception("Asignatura no tiene profesores");
            }
            else
            {
                return profesores;
            }
        }

        public  List<string> Cantidad_De_Estudiantes_Necesarios(List<string> estudiantes)
        {

            if (estudiantes.Count() < 4)
            {
                throw new Exception("Asignatura no tiene suficientes estudiantes");
            }
            else
            {
                return estudiantes;

            }
        }

      
        public static bool CreditoAceptable(int creditos)
        {
            if (creditos < 0 || creditos > 5)
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
