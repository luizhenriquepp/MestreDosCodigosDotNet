using System.Globalization;

namespace Exercicio3_ContaBancaria
{
    public static class Extensions
    {
        public static string ValorFormatado(this decimal valor)
        {
            return valor.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
