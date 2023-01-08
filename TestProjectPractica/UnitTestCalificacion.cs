using Practica;
namespace TestProjectPractica
{
    public class UnitTestCalificacion
    {
        [Theory]
        [InlineData(40)]
        [InlineData(82)]
        [InlineData(98)]
        [InlineData(60)]
        public void Verificar_Margen_De_Notas_True(float nota)
        {
         
            bool verificarMargen = Calificacion.MargenDeNotas(nota);
            // Assert
            Assert.True(verificarMargen);
        }


        [Theory]
        [InlineData(200)]
        [InlineData(-8)]
        [InlineData(101)]
        [InlineData(-4)]
        public void Verificar_Margen_De_Notas_False(float nota)
        {
            bool verificarMargen = Calificacion.MargenDeNotas(nota);
            // Assert
            Assert.False(verificarMargen);
        }
    }
}
