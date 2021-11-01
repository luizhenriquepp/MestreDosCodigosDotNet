using LibConsole;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4_NotasAlunos
{
    class Program
    {
        static void Main()
        {
            var listaAlunos = RetornarListaAlunos();

            ImprimirEstatisticasSolucao1(listaAlunos);
            ImprimirEstatisticasSolucao2(listaAlunos);
        }

        static List<Aluno> RetornarListaAlunos()
        {
            var listaAlunos = new List<Aluno>();
            var quantidadeAlunos = ValidacaoEntradas<int>.RetornarValorValido("Digite a quantidade de alunos: ");

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                var aluno = RetornarAluno(i);
                listaAlunos.Add(aluno);
            }

            return listaAlunos;
        }

        static Aluno RetornarAluno(int indice)
        {
            bool valorValido;
            var aluno = new Aluno
            {
                Nome = ValidacaoEntradas<string>.RetornarValorValido($"Digite o nome do aluno {indice + 1}: ")
            };

            do
            {
                try
                {
                    valorValido = true;
                    aluno.Nota = ValidacaoEntradas<double>.RetornarValorValido($"Digite a nota do aluno {indice + 1}: ");
                }
                catch
                {
                    valorValido = false;
                }

                if (!valorValido)
                    Console.WriteLine("Nota inválida");
            } while (!valorValido);

            return aluno;
        }

        static void ImprimirEstatisticasSolucao1(List<Aluno> listaAlunos)
        {
            var listaAlunosAprovados = new List<string>();

            Console.WriteLine("Solução 1");

            foreach (var aluno in listaAlunos)
                if (aluno.AlunoAprovado())
                    listaAlunosAprovados.Add($"{aluno.Nome}-{aluno.Nota}");

            Console.WriteLine($"Alunos aprovados(Média maior que {Aluno.NotaDeCorte}): {string.Join(", ", listaAlunosAprovados)}");
        }

        static void ImprimirEstatisticasSolucao2(List<Aluno> listaAlunos)
        {
            Console.WriteLine("Solução 2");

            var alunosAprovados = listaAlunos
                .Where(a => a.AlunoAprovado())
                .Select(a => $"{a.Nome}-{a.Nota}")
                .ToList();

            Console.WriteLine($"Alunos aprovados(Média maior que {Aluno.NotaDeCorte}): {string.Join(", ", alunosAprovados)}");
        }
    }
}
