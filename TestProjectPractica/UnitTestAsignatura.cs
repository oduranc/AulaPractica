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
            Asignatura asignatura = new Asignatura();
            string estudiante1 = "Pedro";
            string estudiante2 = "Luis";
            string estudiante3 = "Ana";
            string estudiante4 = "Juan";
            asignatura.estudiantes.Add(estudiante1);
            asignatura.estudiantes.Add(estudiante2);
            asignatura.estudiantes.Add(estudiante3);
            asignatura.estudiantes.Add(estudiante4);

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
            Asignatura asignatura = new Asignatura();
            string estudiante1 = "Pedro";
            string estudiante2 = "Luis";

            // Act
            asignatura.estudiantes.Add(estudiante1);
            asignatura.estudiantes.Add(estudiante2);

            // Assert
            Assert.Throws<Exception>(() => asignatura.Cantidad_De_Estudiantes_Necesarios(asignatura.estudiantes));
           
        }


        [Fact]
        public void Profesores_Impartiendo_Materia_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura();
            string profesor = "Pedro";
            asignatura.profesores.Add(profesor);

            // Act
            asignatura.Cantidad_De_profesores(asignatura.profesores);
            int lenght = asignatura.profesores.Count();
      
            // Assert
            Assert.Equal(1, lenght);
        }


        [Fact]
        public void Profesores_Impartiendo_Materia_No_Aceptable()
        {
            // Arrange
            Asignatura asignatura = new Asignatura();
  

            // Assert
            Assert.Throws<Exception>(() => asignatura.Cantidad_De_profesores(asignatura.profesores));
        }
    }
}
