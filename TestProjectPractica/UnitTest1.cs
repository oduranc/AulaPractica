using Practica;

namespace TestProjectPractica
{
    public class UnitTest1
    {
        // Arrange
        [Theory]
        [InlineData(69.5)]
        [InlineData(70)]
        [InlineData(82)]
        [InlineData(95)]
        public void Pasar_True(float nota)
        {
            // Assert
            Assert.True(Estudiante.Pasar(nota));
        }

        [Theory]
        [InlineData(69)]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(25)]
        public void Pasar_False(float nota)
        {
            Assert.False(Estudiante.Pasar(nota));
        }

        [Fact]
        public void Inscribir_Una_Materia_Dos_Veces()
        {
            Estudiante estudiante = new Estudiante("Ingeniería de Software");
            string materia1 = "Construcción de Software";
            string materia2 = "Laboratorio Construcción de Software";
            estudiante.Inscribir(materia1);
            estudiante.Inscribir(materia2);
            Assert.Throws<Exception>(() => estudiante.Inscribir(materia1));
        }
    }
}