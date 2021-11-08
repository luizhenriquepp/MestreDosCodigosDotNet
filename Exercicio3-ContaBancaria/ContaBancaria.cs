using System;

namespace Exercicio3_ContaBancaria
{
    public abstract class ContaBancaria : IImprimivel
    {
        private const int PrecisaoCasasDecimais = 3;
        public int NumeroConta { get; set; }
        public decimal Saldo { get; protected set; }

        protected ContaBancaria(int numeroConta)
        {
            NumeroConta = numeroConta;
        }

        protected virtual decimal ArredondarValor(decimal valor) =>
             Math.Round(valor, PrecisaoCasasDecimais);

        protected void ValidarValorInvalido(decimal valor)
        {
            if (valor < 0)
                throw new Exception("Valor inválido!");
        }

        public virtual void Sacar(decimal valor)
        {
            ValidarValorInvalido(valor);
        }

        public virtual void Depositar(decimal valor)
        {
            ValidarValorInvalido(valor);
        }

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo da conta: {Saldo.ValorFormatado()}");
        }
    }
}
