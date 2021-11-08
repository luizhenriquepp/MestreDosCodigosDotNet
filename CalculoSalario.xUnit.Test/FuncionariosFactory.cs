using System.Collections.Generic;

namespace CalculoSalario.xUnit.Test
{
    public static class FuncionariosFactory
    {
        public static KeyValuePair<string, double> ObterFuncionarioTrainee()
        {
            return new KeyValuePair<string, double>("João Trainee", 1000);
        }

        public static KeyValuePair<string, double> ObterFuncionarioJunior()
        {
            return new KeyValuePair<string, double>("Pedro Junior", 3000);
        }

        public static KeyValuePair<string, double> ObterFuncionarioPleno()
        {
            return new KeyValuePair<string, double>("Maria Pleno", 5000);
        }

        public static KeyValuePair<string, double> ObterFuncionarioSenior()
        {
            return new KeyValuePair<string, double>("Marta Senior", 8000);
        }

        public static List<KeyValuePair<string, double>> ObterFuncionarios()
        {
            var funcionarios = new List<KeyValuePair<string, double>>
            {
                ObterFuncionarioPleno(),
                ObterFuncionarioSenior(),
                ObterFuncionarioJunior(),
                ObterFuncionarioTrainee()
            };

            return funcionarios;
        }
    }
}
