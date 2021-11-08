using System;

namespace Exercicio3_ContaBancaria
{
    public class ContaEspecial : ContaBancaria
    {
        public decimal Limite { get; set; }
        public decimal LimiteDisponivel {
            get => Limite + Saldo;
        }

        public ContaEspecial(int numeroConta, decimal limite) : base(numeroConta)
        {
            Limite = ArredondarValor(limite);
        }

        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            valor = ArredondarValor(valor);

            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);

            valor = ArredondarValor(valor);

            if (valor > Saldo + Limite)
                throw new SaldoInsuficienteException($"Saldo insuficiente. O valor do saque ({valor.ValorFormatado()}) ultrapassa o saldo ({Saldo.ValorFormatado()}) mais limite ({Limite.ValorFormatado()}).");

            Saldo -= valor;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("==== DADOS DA CONTA ESPECIAL =====");
            base.MostrarDados();
            Console.WriteLine($"Limite contratado: {Limite.ValorFormatado()}");
            Console.WriteLine($"Limite disponível: {LimiteDisponivel.ValorFormatado()}");
            Console.WriteLine("==================================");
        }
    }
}
