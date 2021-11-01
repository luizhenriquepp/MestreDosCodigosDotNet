using System;
using LibConsole;

namespace Exercicio1_Calculadora
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();

                var valorA = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor A: ");
                var valorB = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor B: ");

                var centralOperacoes = new CentralDeOperacoes(valorA, valorB);
                centralOperacoes.Executar();

                Console.Write("Informar novos valores? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
