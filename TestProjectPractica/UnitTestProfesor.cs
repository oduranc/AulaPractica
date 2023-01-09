using Practica;

namespace TestProjectPractica
{
    public class UnitTestProfesor
    {
        [Fact]
        public void Impartir_Una_Materia_Dos_Veces()
        {
            // Arrange
            Profesor profesor = new Profesor("Luis Duarte");
            Asignatura materia1 = new Asignatura("Construcción de Software");
            Asignatura materia2 = new Asignatura("Laboratorio Construcción de Software");
            
            // Act
            profesor.Inscribir(materia1);
            profesor.Inscribir(materia2);
            // Assert
            Assert.Throws<Exception>(() => profesor.Inscribir(materia1));
        }

      

        [Fact]
        public void Impartir_Solo_Una_Vez()
        {
            // Arrange
            Profesor profesor = new Profesor("Ana Tejeda");
            Asignatura materia1 = new Asignatura("Construcción de Software");
            Asignatura materia2 = new Asignatura("Laboratorio Construcción de Software");
           
            // Act
            profesor.Inscribir(materia1);
            profesor.Inscribir(materia2);
            int lenght = profesor.impartiendo.Count();
            // Assert
            Assert.Equal(2, lenght);
        }
    }
}