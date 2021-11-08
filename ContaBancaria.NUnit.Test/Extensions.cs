using NUnit.Framework;
using System;

namespace ContaBancaria.NUnit.Test
{
    public static class Extensions
    {
        const double ToleranciaDouble = 0.001;

        public static void ComMensagem(this Exception exception, string mensagem) =>
            Assert.AreEqual(mensagem, exception.Message);

        public static void AreDecimalEqual(decimal valorEsperado, decimal valor) =>
            Assert.Less(Math.Abs(valorEsperado - valor), ToleranciaDouble);
    }
}
