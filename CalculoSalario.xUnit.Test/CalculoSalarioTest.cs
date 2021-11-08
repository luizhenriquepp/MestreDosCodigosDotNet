using ExpectedObjects;
using System.Collections.Generic;
using Xunit;

namespace CalculoSalario.xUnit.Test
{
    public class CalculoSalarioTest
    {
        private readonly List<KeyValuePair<string, double>> _funcionarios;

        public CalculoSalarioTest()
        {
            _funcionarios = FuncionariosFactory.ObterFuncionarios();
        }

        [Fact]
        public void DeveRetornarMaiorSalario()
        {
            var funcionarioEsperado = FuncionariosFactory.ObterFuncionarioSenior();

            var funcionario = Exercicio2_Salarios.CalculoSalario.GetFuncionarioComMaiorSalario(_funcionarios);

            funcionarioEsperado.ToExpectedObject().ShouldMatch(funcionario);
        }

        [Fact]
        public void DeveRetornarMenorSalario()
        {
            var funcionarioEsperado = FuncionariosFactory.ObterFuncionarioTrainee();

            var funcionario = Exercicio2_Salarios.CalculoSalario.GetFuncionarioComMenorSalario(_funcionarios);

            funcionarioEsperado.ToExpectedObject().ShouldMatch(funcionario);
        }
    }
}
