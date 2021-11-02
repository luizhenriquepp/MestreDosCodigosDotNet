using LibConsole;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio9_Linq
{
    class Program
    {
        static void Main()
        {
            var listaInteiros = RetornarListaInteiros();
            if (listaInteiros.Count() == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }

            ImprmirTodosNumerosDaLista(listaInteiros);
            ImprimirTodosNumerosDaListaEmOrdemCrescente(listaInteiros);
            ImprimirTodosNumerosDaListaEmOrdemDecrescente(listaInteiros);
            ImprimirPrimeiroNumeroDaLista(listaInteiros);
            ImprimirUltimoNumeroDaLista(listaInteiros);
            InserirNumeroNoInicioDaLista(ref listaInteiros);
            InserirNumeroNoFinalDaLista(ref listaInteiros);
            RemoverPrimeiroNumero(ref listaInteiros);
            RemoverUltimoNumero(ref listaInteiros);
            ImprimirNumerosPares(listaInteiros);
            RetornarNumeroDaPosicaoInformada(listaInteiros);
            VerificarListaContemNumeroInformado(listaInteiros);
            ConverterParaArray(listaInteiros);
        }

        static List<int> RetornarListaInteiros()
        {
            var listaInteiros = new List<int>();
            var quantidadeInteiros = ValidacaoEntradas<int>.RetornarValorValido("Digite a quantidade de inteiros: ");

            for (int i = 1; i <= quantidadeInteiros; i++)
            {
                var valor = ValidacaoEntradas<int>.RetornarValorValido($"Digite o valor {i}: ");
                listaInteiros.Add(valor);
            }

            return listaInteiros;
        }

        static void ImprmirTodosNumerosDaLista(List<int> listaInteiros)
        {
            Console.WriteLine($"1.1-Itens da lista com Join: {String.Join(",", listaInteiros)}");

            var listaString = listaInteiros.ConvertAll(delegate (int i)
            {
                return i.ToString();
            });

            Console.WriteLine($"1.2-Itens da lista com Aggregate: {listaString.Aggregate((x, y) => x + "," + y)}");
        }

        static void ImprimirTodosNumerosDaListaEmOrdemCrescente(List<int> listaInteiros)
        {
            listaInteiros = listaInteiros
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine($"2-Itens da lista em ordem crescente: {String.Join(",", listaInteiros)}");
        }

        static void ImprimirTodosNumerosDaListaEmOrdemDecrescente(List<int> listaInteiros)
        {
            listaInteiros = listaInteiros
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine($"3-Itens da lista em ordem decrescente: {String.Join(",", listaInteiros)}");
        }

        static void ImprimirPrimeiroNumeroDaLista(List<int> listaInteiros)
        {
            Console.WriteLine($"4-Primeiro número da lista: {listaInteiros.First()}");
        }

        static void ImprimirUltimoNumeroDaLista(List<int> listaInteiros)
        {
            Console.WriteLine($"5-Último número da lista: {listaInteiros.Last()}");
        }

        static void InserirNumeroNoInicioDaLista(ref List<int> listaInteiros)
        {
            var novoValor = ValidacaoEntradas<int>.RetornarValorValido("Digite o valor que será acrescentado no início da lista: ");

            listaInteiros = listaInteiros
                .Prepend(novoValor)
                .ToList();
            
            Console.WriteLine($"6-Inserção no início da lista: {String.Join(",", listaInteiros)}");
        }

        static void InserirNumeroNoFinalDaLista(ref List<int> listaInteiros)
        {
            var novoValor = ValidacaoEntradas<int>.RetornarValorValido("Digite o valor que será acrescentado no final da lista: ");

            listaInteiros = listaInteiros
                .Append(novoValor)
                .ToList();

            Console.WriteLine($"7-Inserção no fim da lista: {String.Join(",", listaInteiros)}");
        }

        static void RemoverPrimeiroNumero(ref List<int> listaInteiros)
        {
            listaInteiros = listaInteiros
                .Skip(1)
                .ToList();

            Console.WriteLine($"8-Remoção do primeiro número usando linq: {String.Join(",", listaInteiros)}");
        }

        static void RemoverUltimoNumero(ref List<int> listaInteiros)
        {
            listaInteiros = listaInteiros
                .SkipLast(1)
                .ToList();

            Console.WriteLine($"9-Remoção do último número usando linq: {String.Join(",", listaInteiros)}");
        }

        static void ImprimirNumerosPares(List<int> listaInteiros)
        {
            listaInteiros = listaInteiros
                .Where(x => Calculadora.NumeroPar(x))
                .ToList();

            Console.WriteLine($"10-Números pares da lista: {String.Join(",", listaInteiros)}");
        }

        static void RetornarNumeroDaPosicaoInformada(List<int> listaInteiros)
        {
            var posicao = ValidacaoEntradas<int>.RetornarValorValido("Digite a posição: ");
            if ((posicao < 1) || (posicao > listaInteiros.Count))
            {
                Console.WriteLine("11.1-Posição inválida");
                return;
            }

            Console.WriteLine($"11.1-O valor contido na posição {posicao} é: {listaInteiros.ElementAt(posicao-1)}");
        }

        static void VerificarListaContemNumeroInformado(List<int> listaInteiros)
        {
            var valor = ValidacaoEntradas<int>.RetornarValorValido("Digite o valor a ser verificado: ");
            var estaNaLista = Enumerable.Contains(listaInteiros, valor);
            var textoComplemento = estaNaLista ? "" : "não ";

            Console.WriteLine($"11.2-O valor {valor} {textoComplemento}está na lista.");
        }

        static void ConverterParaArray(List<int> listaInteiros)
        {
            var array = Enumerable.ToArray(listaInteiros);

            Console.WriteLine($"12-Convertendo para array pelo linq: {String.Join(",", array)}");
        }
    }
}
