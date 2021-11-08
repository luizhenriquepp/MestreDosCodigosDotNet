using System.Collections.Generic;

namespace Exercicio2_Salarios
{
    public static class CalculoSalario
    {
        public static KeyValuePair<string, double>? GetFuncionarioComMenorSalario(List<KeyValuePair<string, double>> funcionarios)
        {
            if (funcionarios.Count == 0)
                return null;

            var funcionarioMenorSalario = funcionarios[0];

            for (int i = 1; i < funcionarios.Count; i++)
                if (funcionarios[i].Value < funcionarioMenorSalario.Value)
                    funcionarioMenorSalario = funcionarios[i];

            return funcionarioMenorSalario;
        }

        public static KeyValuePair<string, double>? GetFuncionarioComMaiorSalario(List<KeyValuePair<string, double>> funcionarios)
        {
            if (funcionarios.Count == 0)
                return null;

            var funcionarioMaiorSalario = funcionarios[0];

            for (int i = 1; i < funcionarios.Count; i++)
                if (funcionarios[i].Value > funcionarioMaiorSalario.Value)
                    funcionarioMaiorSalario = funcionarios[i];

            return funcionarioMaiorSalario;
        }
    }
}
