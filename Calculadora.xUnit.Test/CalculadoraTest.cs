using System;
using Xunit;

namespace Calculadora.xUnit.Test
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(-2, 17.5)]
        [InlineData(2, -17.5)]
        [InlineData(-2, -5.5)]
        [InlineData(12.5, 26.8)]
        public void DeveSomarNumeros(double numero1, double numero2)
        {
            var resultadoEsperado = numero1 + numero2;

            var resultado = LibConsole.Calculadora.Somar(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-3, 21.7)]
        [InlineData(10, -5.1)]
        [InlineData(-7.2, -1.9)]
        [InlineData(8.95, 13.5)]
        public void DeveSubtrairNumeros(double numero1, double numero2)
        {
            var resultadoEsperado = numero1 - numero2;

            var resultado = LibConsole.Calculadora.Subtrair(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(-7, 2)]
        [InlineData(18, -5.1)]
        [InlineData(-13.7, -1.9)]
        [InlineData(2.5, 13.5)]
        public void DeveDividirNumeros(double numero1, double numero2)
        {
            var resultadoEsperado = numero2 / numero1;

            var resultado = LibConsole.Calculadora.Dividir(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(0, -2)]
        [InlineData(0, 0)]
        public void NaoDeveDividirPorZero(double numero1, double numero2)
        {
            Assert.Throws<ArgumentException>(() =>
                LibConsole.Calculadora.Dividir(numero1, numero2))
                .ComMensagem("Não é possível dividir por zero. Por favor, informe um valor válido.");
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-2, 4)]
        [InlineData(5, -8.5)]
        [InlineData(-5.5, -2.9)]
        [InlineData(5.5, 2.5)]
        public void DeveMultiplicarNumeros(double numero1, double numero2)
        {
            var resultadoEsperado = numero1 * numero2;

            var resultado = LibConsole.Calculadora.Multiplicar(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(2)]
        [InlineData(4)]
        public void DeveSerPar(int numero)
        {
            var paridade = LibConsole.Calculadora.NumeroPar(numero);

            Assert.True(paridade);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(-3)]
        [InlineData(3)]
        [InlineData(5)]
        public void DeveSerImpar(int numero)
        {
            var paridade = LibConsole.Calculadora.NumeroPar(numero);

            Assert.False(paridade);
        }
    }
}
