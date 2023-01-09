using Practica;

namespace TestProjectPractica
{
    public class UnitTestEstudiante
    {
        // Arrange
        [Theory]
        [InlineData(69.5)]
        [InlineData(70)]
        [InlineData(82)]
        [InlineData(95)]
        public void Pasar_True(float calificacion)
        {
            Calificacion calificaciones = new Calificacion(calificacion);
            // Act
            bool pasar = Estudiante.Pasar(calificaciones);
            // Assert
            Assert.True(pasar);
        }

        // Arrange
        [Theory]
        [InlineData(69)]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(25)]
        public void Pasar_False(float calificacion)
        {
            Calificacion calificaciones= new Calificacion(calificacion);
            // Act
            bool pasar = Estudiante.Pasar(calificaciones);
            // Assert
            Assert.False(pasar);
        }

        [Fact]
        public void Inscribir_Una_Materia_Dos_Veces()
        {
            // Arrange
            Estudiante estudiante = new Estudiante("Pablo Cespedes");
            Asignatura materia1 = new Asignatura("Construcción de Software");
            Asignatura materia2 = new Asignatura("Laboratorio Construcción de Software");
            // Act
            estudiante.Inscribir(materia1);
            estudiante.Inscribir(materia2);
            // Assert
            Assert.Throws<Exception>(() => estudiante.Inscribir(materia1));
        }

        [Fact]
        public void Inscribir_Solo_Una_Vez()
        {
            // Arrange
            Estudiante estudiante = new Estudiante("Luisa Perez");
            Asignatura materia1 = new Asignatura("Desarrollo de Software III");
            Asignatura materia2 = new Asignatura("Laboratorio Desarrollo de Software III");
            // Act
            estudiante.Inscribir(materia1);
            estudiante.Inscribir(materia2);
            int lenght = estudiante.cursando.Count();
            // Assert
            Assert.Equal(2, lenght);
        }
    }
}