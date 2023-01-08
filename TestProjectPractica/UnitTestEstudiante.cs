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
        public void Pasar_True(float nota)
        {
            // Act
            bool pasar = Estudiante.Pasar(nota);
            // Assert
            Assert.True(pasar);
        }

        // Arrange
        [Theory]
        [InlineData(69)]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(25)]
        public void Pasar_False(float nota)
        {
            // Act
            bool pasar = Estudiante.Pasar(nota);
            // Assert
            Assert.False(pasar);
        }

        [Fact]
        public void Inscribir_Una_Materia_Dos_Veces()
        {
            // Arrange
            Estudiante estudiante = new Estudiante("Ingeniería de Software");
            string materia1 = "Construcción de Software";
            string materia2 = "Laboratorio Construcción de Software";
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
            Estudiante estudiante = new Estudiante("Ingeniería de Software");
            string materia1 = "Desarrollo de Software III";
            string materia2 = "Laboratorio Desarrollo de Software III";
            // Act
            estudiante.Inscribir(materia1);
            estudiante.Inscribir(materia2);
            int lenght = estudiante.cursando.Count();
            // Assert
            Assert.Equal(2, lenght);
        }
    }
}