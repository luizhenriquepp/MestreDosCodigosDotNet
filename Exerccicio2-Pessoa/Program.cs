using LibConsole;
using System;

namespace Exerccicio2_Pessoa
{
    class Program
    {
        static void Main()
        {
            var nome = ValidacaoEntradas<string>.RetornarValorValido("Digite o nome da pessoa: ");
            var dataNascimento = ValidacaoEntradas<DateTime>.RetornarValorValido("Digite a data de nascimento: ");
            var altura = ValidacaoEntradas<double>.RetornarValorValido("Digite a altura: ");

            Console.WriteLine();

            try
            {
                var pessoa = new Pessoa
                {
                    Nome = nome,
                    DataNascimento = dataNascimento,
                    Altura = altura
                };
                pessoa.ImprmirDadosPessoa();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao definir a pessoa: {e.Message}");
            }
        }
    }
}
