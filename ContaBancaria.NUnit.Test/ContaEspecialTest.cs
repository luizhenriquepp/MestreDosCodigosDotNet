using Bogus;
using Exercicio3_ContaBancaria;
using NUnit.Framework;
using System;

namespace ContaBancaria.NUnit.Test
{
    public class ContaEspecialTest
    {
        private const int PrecisaoCasasDecimais = 3;
        private int _numeroConta;
        private decimal _limite;
        private decimal _valor;
        private ContaEspecial _contaEspecial;

        [SetUp]
        public void Setup()
        {
            var faker = new Faker();
            _numeroConta = faker.Random.UShort();
            _limite = faker.Random.Decimal(1000, 10000);
            _valor = faker.Random.Decimal(1, 100000);
            _contaEspecial = new ContaEspecial(_numeroConta, _limite);
        }

        private decimal ArredondarValor(decimal valor) =>
            Math.Round(valor, PrecisaoCasasDecimais);

        [Test]
        public void NaoDeveDepositarValorNegativo()
        {
            Assert.Throws<Exception>(() =>
                _contaEspecial.Depositar(-_valor))
                .ComMensagem("Valor inválido!");
        }

        [Test]
        public void NaoDeveSacarValorNegativo()
        {
            Assert.Throws<Exception>(() =>
                _contaEspecial.Sacar(-_valor))
                .ComMensagem("Valor inválido!");
        }

        [Test]
        public void NaoDeveSacarSeUltrapassaLimite()
        {
            _contaEspecial.Depositar(_valor);
            var valorSaqueMaiorLimite = _contaEspecial.LimiteDisponivel + 0.01m;

            Assert.Throws<SaldoInsuficienteException>(() =>
                _contaEspecial.Sacar(valorSaqueMaiorLimite));
        }

        [Test]
        public void DepositoDeveAtualizarSaldo()
        {
            _contaEspecial.Depositar(_valor);

            var valorEsperado = ArredondarValor(_valor);
            Extensions.AreDecimalEqual(valorEsperado, _contaEspecial.Saldo);
        }

        [Test]
        public void DepositoDeveAtualizarLimiteDisponivel()
        {
            _contaEspecial.Depositar(_valor);

            var valorLimiteDisponivelEsperado = ArredondarValor(_valor) + ArredondarValor(_limite);
            Extensions.AreDecimalEqual(valorLimiteDisponivelEsperado, _contaEspecial.LimiteDisponivel);
        }

        [Test]
        public void SaqueDeveAtualizarSaldo()
        {
            _contaEspecial.Depositar(_valor);
            _contaEspecial.Depositar(_valor);
            _contaEspecial.Sacar(_valor);

            var valorSaldoEsperado = 2 * ArredondarValor(_valor) - ArredondarValor(_valor);
            Extensions.AreDecimalEqual(valorSaldoEsperado, _contaEspecial.Saldo);
        }

        [Test]
        public void SaqueDeveAtualizarLimiteDisponivel()
        {
            _contaEspecial.Depositar(_valor);
            _contaEspecial.Depositar(_valor);
            _contaEspecial.Sacar(_valor);

            var valorLimiteDisponivelEsperado = 2 * ArredondarValor(_valor) - ArredondarValor(_valor) + ArredondarValor(_limite);
            Extensions.AreDecimalEqual(valorLimiteDisponivelEsperado, _contaEspecial.LimiteDisponivel);
        }

        [Test]
        public void DevePermitirSacarTodoLimiteDisponivel()
        {
            _contaEspecial.Depositar(_valor);
            _contaEspecial.Sacar(_contaEspecial.LimiteDisponivel);

            Extensions.AreDecimalEqual(_contaEspecial.Limite, -_contaEspecial.Saldo);
        }
    }
}