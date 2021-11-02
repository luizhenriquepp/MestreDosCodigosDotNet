using LibConsole;
using System;
using System.Collections.Generic;

namespace Exercicio8_DecimaisCrescenteDecrescente
{
    class Program
    {
        static void Main()
        {
            var listaDecimais = RetornarListaDecimais();
            var listaDecimaisCopia = new List<double>(listaDecimais);

            ExecutarOrdenacaoPadrao(listaDecimais);
            ExecutarOrdenacaoBubbleSort(listaDecimaisCopia);
        }

        static List<double> RetornarListaDecimais()
        {
            var listaDecimais = new List<double>();
            var quantidadeDecimais = ValidacaoEntradas<int>.RetornarValorValido("Digite a quantidade de decimais: ");

            for (int i = 1; i <= quantidadeDecimais; i++)
            {
                var valor = ValidacaoEntradas<double>.RetornarValorValido($"Digite o valor {i}: ");
                listaDecimais.Add(valor);
            }

            return listaDecimais;
        }

        static void ExecutarOrdenacaoPadrao(List<double> listaDecimais)
        {
            var context = new Context(
                new OrdenacaoPadrao(), 
                listaDecimais);

            context.Executar();

            Console.WriteLine("Solução 1 - Ordenação padrão");
            ImprimirLista(listaDecimais);
        }

        static void ExecutarOrdenacaoBubbleSort(List<double> listaDecimais)
        {
            var context = new Context(
                new OrdenacaoBubbleSort(),
                listaDecimais);

            context.Executar();

            Console.WriteLine("Solução 2 - Ordenação BubbleSort");
            ImprimirLista(listaDecimais);
        }

        static void ImprimirLista(List<double> listaDecimais)
        {
            Console.WriteLine($"Lista em ordem crescente: {string.Join(", ", listaDecimais)}");

            listaDecimais.Reverse();
            
            Console.WriteLine($"Lista em ordem decrescente: {string.Join(", ", listaDecimais)}");
        }
    }
}
