using Calculadora.Services;

namespace CalculadoraTeste
{
    public class CalculadoraTests
    {

        private CalculadoraImp _calc;

        public CalculadoraTests()
        {
            _calc = new CalculadoraImp();
        }

        [Fact]
        public void Somar()
        {
            // Arrange
            int num1 = 10;
            int num2 = 10;

            // Act
            int resultadoSoma = _calc.Somar(num1, num2);

            // Assert
            Assert.Equal(20, resultadoSoma);
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, _calc.Subtrair(10, 10));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, _calc.Multiplicar(10, 10));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, _calc.Dividir(10, 10));
        }

        [Fact]
        public void RetornarVerdadeiroSeONumeroForPar()
        {
            Assert.True(_calc.VerificarSeEPar(2));
        }

        // Realizar mais de um teste no mesmo metodo
        [Theory]
        [InlineData(new int[] {1, 3})]
        [InlineData(new int[] {5, 7, 9})]
        public void RetornarVerdadeiroSeONumeroForImpar(int[] numeros)
        {
            Assert.All(numeros, num => Assert.True(_calc.VerificarSeEImpar(num)));
        }
    }
}