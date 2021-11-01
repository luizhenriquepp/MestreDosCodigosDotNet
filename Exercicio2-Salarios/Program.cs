using LibConsole;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio2_Salarios
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> funcionarios = new Dictionary<string, double>();
            var quantidadeFuncionarios = ValidacaoEntradas<int>.RetornarValorValido("Digite a quantidade de funcionários: ");

            int i = 0;
            while (i < quantidadeFuncionarios)
            {
                var nome = ValidacaoEntradas<string>.RetornarValorValido($"Digite o nome do funcionário {i + 1}: ");
                var salario = ValidacaoEntradas<double>.RetornarValorValido($"Digite o salário do funcionário {i + 1}: ");

                funcionarios.Add(nome, salario);

                i++;
            }

            ImprimirEstatisticasSolucao1(funcionarios);
            ImprimirEstatisticasSolucao2(funcionarios);
        }

        private static void ImprimirEstatisticasSolucao1(Dictionary<string, double> funcionarios)
        {
            Console.WriteLine("Solução 1");

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Lista de funcionários vazia");
                return;
            }

            var funcionarioMenorSalario = funcionarios.ElementAt(0);
            var funcionarioMaiorSalario = funcionarios.ElementAt(0);

            for (int i = 1; i < funcionarios.Count; i++)
            {
                var funcionario = funcionarios.ElementAt(i);

                if (funcionario.Value < funcionarioMenorSalario.Value)
                    funcionarioMenorSalario = funcionario;

                if (funcionario.Value > funcionarioMaiorSalario.Value)
                    funcionarioMaiorSalario = funcionario;
            }

            Console.WriteLine($"Menor salário: {funcionarioMenorSalario}");
            Console.WriteLine($"Maior salário: {funcionarioMaiorSalario}");
        }

        private static void ImprimirEstatisticasSolucao2(Dictionary<string, double> funcionarios)
        {
            Console.WriteLine("Solução 2 - Linq");

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Lista de funcionários vazia");
                return;
            }

            var funcionarioMaiorSalario = funcionarios.Aggregate((x, y) => x.Value > y.Value ? x : y);
            var funcionarioMenorSalario = funcionarios.Aggregate((x, y) => x.Value < y.Value ? x : y);

            Console.WriteLine($"Menor salário: {funcionarioMenorSalario}");
            Console.WriteLine($"Maior salário: {funcionarioMaiorSalario}");
        }
    }
}
