using System;
using System.ComponentModel;

namespace LibConsole
{
    public static class ValidacaoEntradas<T>
    {
        public static T RetornarValorValido(string rotuloValor)
        {
            T valor;
            bool valorValido;
            var converter = TypeDescriptor.GetConverter(typeof(T));

            do
            {
                Console.Write(rotuloValor);

                try
                {
                    valorValido = true;
                    valor = (T)converter.ConvertFromString(Console.ReadLine());
                }
                catch
                {
                    valorValido = false;
                    valor = default;
                }

                if (!valorValido)
                    Console.WriteLine("Valor inválido");
            } while (!valorValido);

            return valor;
        }
    }
}
