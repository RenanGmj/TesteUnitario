using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacaoStringTest
    {
        private ValidacoesString _validacoes;

        public ValidacaoStringTest()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            string texto = "Ola";

            int resultado = _validacoes.ContarCaracteres(texto);

            Assert.Equal(3, resultado);
        }
    }
}