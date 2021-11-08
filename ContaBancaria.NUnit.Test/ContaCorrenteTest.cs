using Bogus;
using Exercicio3_ContaBancaria;
using NUnit.Framework;
using System;

namespace ContaBancaria.NUnit.Test
{
    public class ContaCorrenteTest
    {
        private const int PrecisaoCasasDecimais = 3;
        private int _numeroConta;
        private decimal _taxaOperacao;
        private decimal _valor;
        private decimal _valorMenorTaxaOperacao;
        private ContaCorrente _contaCorrente;

        [SetUp]
        public void Setup()
        {
            var faker = new Faker();
            _numeroConta = faker.Random.UShort();
            _taxaOperacao = faker.Random.Decimal(5, 10);
            _valor = faker.Random.Decimal(11, 100000);
            _valorMenorTaxaOperacao = faker.Random.Decimal(1, 4);
            _contaCorrente = new ContaCorrente(_numeroConta, _taxaOperacao);
        }

        private decimal ArredondarValor(decimal valor) =>
            Math.Round(valor, PrecisaoCasasDecimais);

        [Test]
        public void NaoDeveDepositarValorNegativo()
        {
            Assert.Throws<Exception>(() =>
                _contaCorrente.Depositar(-_valor))
                .ComMensagem("Valor inválido!");
        }

        [Test]
        public void NaoDeveSacarValorNegativo()
        {
            Assert.Throws<Exception>(() =>
                _contaCorrente.Sacar(-_valor))
                .ComMensagem("Valor inválido!");
        }

        [Test]
        public void NaoDeveDepositarSeValorNaoQuitaTaxaDeOperacao()
        {
            Assert.Throws<SaldoInsuficienteException>(() =>
                _contaCorrente.Depositar(_valorMenorTaxaOperacao));
        }

        [Test]
        public void NaoDeveSacarSeSaldoEhInsuficiente()
        {
            _contaCorrente.Depositar(_valor);
            var valorSaqueMaiorSaldo = _contaCorrente.Saldo + 0.01m;

            Assert.Throws<SaldoInsuficienteException>(() =>
                _contaCorrente.Sacar(valorSaqueMaiorSaldo));
        }

        [Test]
        public void DepositoDeveAtualizarSaldo()
        {
            _contaCorrente.Depositar(_valor);

            var valorEsperado = ArredondarValor(_valor) - ArredondarValor(_taxaOperacao);
            Extensions.AreDecimalEqual(valorEsperado, _contaCorrente.Saldo);
        }

        [Test]
        public void SaqueDeveAtualizarSaldo()
        {
            _contaCorrente.Depositar(_valor);
            _contaCorrente.Depositar(_valor);
            _contaCorrente.Sacar(_valor);

            var valorSaldoEsperado = 2 * ArredondarValor(_valor) - ArredondarValor(_valor) - 3 * ArredondarValor(_taxaOperacao);
            Extensions.AreDecimalEqual(valorSaldoEsperado, _contaCorrente.Saldo);
        }

        [Test]
        public void DevePermitirSacarTodoSaldo()
        {
            _contaCorrente.Depositar(_valor);
            _contaCorrente.Sacar(_contaCorrente.Saldo - ArredondarValor(_taxaOperacao));

            Extensions.AreDecimalEqual(0, _contaCorrente.Saldo);
        }
    }
}