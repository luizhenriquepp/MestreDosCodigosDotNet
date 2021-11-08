using System;
using Xunit;

namespace Calculadora.xUnit.Test
{
    public static class AssertExtension
    {
        public static void ComMensagem(this ArgumentException exception, string mensagem) =>
            Assert.Equal(mensagem, exception.Message);
    }
}
