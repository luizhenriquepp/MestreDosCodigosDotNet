using System;

namespace Exercicio3_ContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal TaxaDeOperacao { get; set; }

        public ContaCorrente(int numeroConta, decimal taxaDeOperacao) : base(numeroConta)
        {
            TaxaDeOperacao = ArredondarValor(taxaDeOperacao);
        }

        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            valor = ArredondarValor(valor);

            if (valor + Saldo < TaxaDeOperacao)
                throw new SaldoInsuficienteException($"Valor do depósito ({valor.ValorFormatado()}) " +
                    $"mais o saldo ({Saldo.ValorFormatado()}) são insuficientes para quitar a taxa de operação ({TaxaDeOperacao.ValorFormatado()}).");

            Saldo = Saldo + valor - TaxaDeOperacao;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);

            valor = ArredondarValor(valor);

            if (valor + TaxaDeOperacao > Saldo)
                throw new SaldoInsuficienteException($"Saldo insuficiente. Saldo: {Saldo.ValorFormatado()}. Valor da operação (saque + taxa): {(valor + TaxaDeOperacao).ValorFormatado()}");

            Saldo = Saldo - valor - TaxaDeOperacao;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("==== DADOS DA CONTA CORRENTE =====");
            base.MostrarDados();
            Console.WriteLine($"Taxa de operação: {TaxaDeOperacao.ValorFormatado()}");
            Console.WriteLine("==================================");
        }
    }
}
