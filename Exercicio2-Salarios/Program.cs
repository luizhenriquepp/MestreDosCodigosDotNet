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
            var funcionarios = GetListaFuncionarios();

            ImprimirEstatisticasSolucao1(funcionarios);
            ImprimirEstatisticasSolucao2(funcionarios);
        }

        private static Dictionary<string, double> GetListaFuncionarios()
        {
            Dictionary<string, double> funcionarios = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            var quantidadeFuncionarios = ValidacaoEntradas<int>.RetornarValorValido("Digite a quantidade de funcionários: ");

            int i = 0;
            while (i < quantidadeFuncionarios)
            {
                var nome = ValidacaoEntradas<string>.RetornarValorValido($"Digite o nome do funcionário {i + 1}: ");
                var salario = ValidacaoEntradas<double>.RetornarValorValido($"Digite o salário do funcionário {i + 1}: ");

                if (AdicionarFuncionario(funcionarios, nome, salario))
                    i++;
            }

            return funcionarios;
        }

        private static bool AdicionarFuncionario(Dictionary<string, double> funcionarios, string nome, double salario)
        {
            try
            {
                funcionarios.Add(nome, salario);
                return true;
            }
            catch
            {
                Console.WriteLine("Funcionário já informado anteriormente. Digite novamente os dados do novo funcionário.");
                return false;
            }
        }

        private static void ImprimirEstatisticasSolucao1(Dictionary<string, double> funcionarios)
        {
            Console.WriteLine("Solução 1");

            var funcionarioMenorSalario = CalculoSalario.GetFuncionarioComMenorSalario(funcionarios.ToList());
            var funcionarioMaiorSalario = CalculoSalario.GetFuncionarioComMaiorSalario(funcionarios.ToList());

            if (funcionarioMenorSalario is null)
            {
                Console.WriteLine("Lista de funcionários vazia");
                return;
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
