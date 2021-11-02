using LibConsole;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio7_SomaPares
{
    class Program
    {
        static void Main()
        {
            const int QuantidadeEntradas = 4;
            var listaEntradas = new List<int>();

            for (int i = 1; i <= QuantidadeEntradas; i++)
            {
                var valor = ValidacaoEntradas<int>.RetornarValorValido($"Digite o valor {i}: ");
                listaEntradas.Add(valor);
            }

            ImprimirEstatisticasSolucao1(listaEntradas);
            ImprimirEstatisticasSolucao2(listaEntradas);
        }

        static void ImprimirEstatisticasSolucao1(List<int> listaEntradas)
        {
            int soma = 0;
            var listaPares = new List<int>();

            foreach (var entrada in listaEntradas)
                if (Calculadora.NumeroPar(entrada))
                {
                    listaPares.Add(entrada);
                    soma += entrada;
                }

            Console.WriteLine("Solução 1");
            Console.WriteLine($"Soma dos pares: {soma} ({string.Join(", ", listaPares)})");
        }

        static void ImprimirEstatisticasSolucao2(List<int> listaEntradas)
        {
            var listaPares = listaEntradas
                .Where(e => Calculadora.NumeroPar(e));

            var soma = listaPares
                .Sum();

            Console.WriteLine("Solução 2 - Linq");
            Console.WriteLine($"Soma dos pares: {soma} ({string.Join(", ", listaPares)})");
        }

    }
}
