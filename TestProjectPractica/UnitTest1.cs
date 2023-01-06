using Practica;

namespace TestProjectPractica
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(69.5)]
        [InlineData(70)]
        [InlineData(82)]
        [InlineData(95)]
        public void Pasar_True(float nota)
        {
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
            Estudiante estudiante = new Estudiante("Ingenier�a de Software");
            string materia1 = "Construcci�n de Software";
            string materia2 = "Laboratorio Construcci�n de Software";
            estudiante.Inscribir(materia1);
            estudiante.Inscribir(materia2);
            Assert.Throws<Exception>(() => estudiante.Inscribir(materia1));
        }
    }
}