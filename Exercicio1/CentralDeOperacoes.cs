using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio1
{
    public class CentralDeOperacoes
    {
        readonly Dictionary<string, Func<double, double, double>> _operacoes;
        readonly double _valorA;
        readonly double _valorB;
        int _indiceMenuDisponivel = 1;
        int _indiceParidade;
        int _indiceSair;

        public CentralDeOperacoes(
            double valorA,
            double valorB)
        {
            _valorA = valorA;
            _valorB = valorB;

            _operacoes = new Dictionary<string, Func<double, double, double>>()
            {
                {"Adição", Calculadora.Somar},
                {"Subtração", Calculadora.Subtrair},
                {"Multiplicação", Calculadora.Multiplicar},
                {"Divisão", Calculadora.Dividir}
            };

        }

        public void Executar()
        {
            ImprimirMenu();

            int indiceMenuEscolhido;
            do
            {
                indiceMenuEscolhido = RetornarIndiceMenuEscolhido();

                ExecutarAcaoMenuEscolhido(indiceMenuEscolhido);
            } while (indiceMenuEscolhido != _indiceSair);
        }

        private void ImprimirMenu()
        {
            Console.WriteLine();
            ImprimirListaMenuOperacoesMatematicas();
            ImprimirMenusAdicionais();
            Console.WriteLine();
        }

        private void ImprimirListaMenuOperacoesMatematicas()
        {
            foreach (var operacao in _operacoes)
                Console.WriteLine($"{_indiceMenuDisponivel++} - {operacao.Key}");
        }

        private void ImprimirMenusAdicionais()
        {
            _indiceParidade = _indiceMenuDisponivel++;
            _indiceSair = _indiceMenuDisponivel++;

            Console.WriteLine($"{_indiceParidade} - Verificação da paridade das entradas");
            Console.WriteLine($"{_indiceSair} - Sair");
        }

        private int RetornarIndiceMenuEscolhido()
        {
            Console.Write("Digite o número do menu: ");
            int.TryParse(Console.ReadLine(), out int indiceMenuEscolhido);

            return indiceMenuEscolhido;
        }

        private bool IndiceOpercaoMatematica(int indice) => 
            (indice >= 1) && (indice <= _operacoes.Count);

        private void ExecutarAcaoMenuEscolhido(int indice)
        {
            if (IndiceOpercaoMatematica(indice))
            {
                ExecutarOperacaoMatematica(indice);
                return;
            }
            
            if (indice == _indiceParidade)
                ExecutaOperacaoParidade();
        }
        
        private void ExecutarOperacaoMatematica(int indice)
        {
            try
            {
                var func = _operacoes.ElementAt(indice - 1).Value;
                var resultado = func(_valorA, _valorB);

                Console.WriteLine($"Resultado da operação: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao executar a operação: {e.Message}");
            }
        }

        private string RetornarTextoParidade(int valor)
        {
            const string TextoPar = "par";
            const string TextoImpar = "ímpar";

            return Calculadora.NumeroPar(valor) ? TextoPar : TextoImpar;
        }

        private void VerificarParidade(string rotuloValor, double valor)
        {
            if (!Int32.TryParse(valor.ToString(), out var valorInt))
            {
                Console.WriteLine($"{rotuloValor} ({valor}) não é inteiro");
                return;
            }

            Console.WriteLine($"{rotuloValor} ({valorInt}) é {RetornarTextoParidade(valorInt)}");
        }

        private void ExecutaOperacaoParidade()
        {
            VerificarParidade("Valor A", _valorA);
            VerificarParidade("Valor B", _valorB);
        }
    }
}
