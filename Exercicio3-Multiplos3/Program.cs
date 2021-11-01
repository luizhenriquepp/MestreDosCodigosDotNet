using LibConsole;
using System;
using System.Collections.Generic;

namespace Exercicio3_Multiplos3
{
    class Program
    {
        static void Main()
        {
            const int LimiteInicial = 1;
            const int LimiteFinal = 100;
            const int BaseMultiplo = 3;
            var listaMultiplos = new List<int>();
            var i = LimiteInicial;

            while (i <= LimiteFinal)
            {
                if (Calculadora.Multiplo(i, BaseMultiplo))
                    listaMultiplos.Add(i);

                i++;
            }

            Console.WriteLine($"Os múltiplos de 3 são: {string.Join(", ", listaMultiplos)}.");
        }
    }
}
