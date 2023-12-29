using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeste
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void ContarTotalDeCaracteresNaString()
        {
            Assert.Equal(5, _validacoes.ContarCaracteres("Caval"));
        }
    }

}
