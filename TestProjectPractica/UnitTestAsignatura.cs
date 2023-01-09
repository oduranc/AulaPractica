using Practica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectPractica
{
    public class UnitTestAsignatura
    {
        [Theory]
        [InlineData(3)]
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(5)]
        public void Creditos_Necesarios_True(int credito)
        {

            bool creditoNecesario = Asignatura.CreditoAceptable(credito);
            // Assert
            Assert.True(creditoNecesario);
        }


        [Theory]
        [InlineData(6)]
        [InlineData(-1)]
        [InlineData(-3)]
        [InlineData(8)]
        public void Creditos_Necesarios_False(int credito)
        {

            bool creditoNecesario = Asignatura.CreditoAceptable(credito);
            // Assert
            Assert.False(creditoNecesario);
        }

        [Fact]
        public void Estudiantes_Cursando_Materia_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("Lenguas");
            Estudiante estudiante1 = new Estudiante("Luis Jimenez");
            Estudiante estudiante2 = new Estudiante("Pedro Lopaz");
            Estudiante estudiante3 = new Estudiante("Maria Almonte");
            Estudiante estudiante4 = new Estudiante("Olif Mendez");
     
            asignatura.estudiantes.Add(estudiante1.nombre.ToString());
            asignatura.estudiantes.Add(estudiante2.nombre.ToString());
            asignatura.estudiantes.Add(estudiante3.nombre.ToString());
            asignatura.estudiantes.Add(estudiante4.nombre.ToString());

            // Act
            asignatura.Cantidad_De_Estudiantes_Necesarios(asignatura.estudiantes);
            int lenght = asignatura.estudiantes.Count();
        
            // Assert
            Assert.Equal(4, lenght);
        }

        [Fact]
        public void Estudiantes_Cursando_Materia_No_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("Impacto Social");
            Estudiante estudiante1 = new Estudiante("Marcos Pimentel");
            Estudiante estudiante2 = new Estudiante("Sandra Rice");


            // Act
            asignatura.estudiantes.Add(estudiante1.nombre.ToString());
            asignatura.estudiantes.Add(estudiante2.nombre.ToString());

            // Assert
            Assert.Throws<Exception>(() => asignatura.Cantidad_De_Estudiantes_Necesarios(asignatura.estudiantes));
           
        }


        [Fact]
        public void Profesores_Impartiendo_Materia_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("Historia");
            Profesor profesor1 = new Profesor("Jose Ferreira");
            Profesor profesor2 = new Profesor("Carla Montez");

            asignatura.profesores.Add(profesor1.nombreDocente.ToString());
            asignatura.profesores.Add(profesor2.nombreDocente.ToString());

            // Act
            asignatura.Cantidad_De_profesores(asignatura.profesores);
            int lenght = asignatura.profesores.Count();
      
            // Assert
            Assert.Equal(2, lenght);
        }


        [Fact]
        public void Profesores_Impartiendo_Materia_No_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("Calculo");
  

            // Assert
            Assert.Throws<Exception>(() => asignatura.Cantidad_De_profesores(asignatura.profesores));
        }
    }
}
