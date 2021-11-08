using System;

namespace Exercicio3_ContaBancaria
{
    class Program
    {
        static void Main()
        {
            ExecutarSimulacaoContaCorrente();

            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para a próxima simulação...");
            Console.ReadKey();
            Console.Clear();

            ExcecutarSimulacaoContaEspecial();
        }

        static void  ExecutarSimulacaoContaCorrente()
        {
            const int NumeroConta = 123456;
            const decimal TaxaDeOperacaoContaCorrente = 10;
            var contaCorrente = new ContaCorrente(NumeroConta, TaxaDeOperacaoContaCorrente);

            contaCorrente.MostrarDados();
            Sacar(contaCorrente, -10);
            Depositar(contaCorrente, -20);
            Sacar(contaCorrente, 200);
            Depositar(contaCorrente, 5);
            Depositar(contaCorrente, 500);
            Sacar(contaCorrente, 200);
            Sacar(contaCorrente, 200);
            Sacar(contaCorrente, 200);
            Sacar(contaCorrente, 60.01m);
            Sacar(contaCorrente, 60);
            contaCorrente.MostrarDados();
        }

        static void ExcecutarSimulacaoContaEspecial()
        {
            const int NumeroConta = 654321;
            const decimal LimiteContaEspecial = 1000;
            var contaEspecial = new ContaEspecial(NumeroConta, LimiteContaEspecial);

            contaEspecial.MostrarDados();
            Sacar(contaEspecial, -10);
            Depositar(contaEspecial, -20);
            Sacar(contaEspecial, 200);
            Sacar(contaEspecial, 800.01m);
            Sacar(contaEspecial, 800.00m);
            Depositar(contaEspecial, 500);
            Sacar(contaEspecial, 200);
            Sacar(contaEspecial, 300.01m);
            contaEspecial.MostrarDados();
        }

        static void Depositar(ContaBancaria conta, decimal valor)
        {
            try
            {
                conta.Depositar(valor);
                ImprimirMensagemSucesso($"O valor {valor.ValorFormatado()} foi depositado com sucesso. Saldo atualizado: {conta.Saldo.ValorFormatado()}");
            }
            catch (Exception e)
            {
                ImprimirMensagemErro($"Erro ao realizar o depósito no valor de {valor.ValorFormatado()}: {e.Message}");
            }
        }

        static void Sacar(ContaBancaria conta, decimal valor)
        {
            try
            {
                conta.Sacar(valor);
                ImprimirMensagemSucesso($"Saque realizado no valor de {valor.ValorFormatado()}. Saldo atualizado: {conta.Saldo.ValorFormatado()}");
            }
            catch (Exception e)
            {
                ImprimirMensagemErro($"Erro ao realizar o saque no valor de {valor.ValorFormatado()}: {e.Message}");
            }
        }

        static void ImprimirMensagemErro(string mensagem)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        static void ImprimirMensagemSucesso(string mensagem)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
