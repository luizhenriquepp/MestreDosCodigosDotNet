using System;

namespace Exercicio1
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();

                var valorA = RetornarValor("valor A");
                var valorB = RetornarValor("valor B");

                var centralOperacoes = new CentralDeOperacoes(valorA, valorB);
                centralOperacoes.Executar();

                Console.Write("Informar novos valores? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }

        private static double RetornarValor(string rotuloValor)
        {
            double valor;
            bool valorValido;

            do
            {
                Console.Write($"Digite o {rotuloValor}: ");

                valorValido = double.TryParse(Console.ReadLine(), out valor);

                if (!valorValido)
                    Console.WriteLine("Valor inválido");
            } while (!valorValido);

            return valor;
        }
    }
}
