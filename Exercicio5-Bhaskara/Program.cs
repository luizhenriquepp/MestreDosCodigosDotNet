using LibConsole;
using System;

namespace Exercicio5_Bhaskara
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Fórmula de Bhaskara");

            ReceberEntradas(out var coeficienteA, out var coeficienteB, out var coeficienteC);

            Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out var delta, out var raiz1, out var raiz2);

            ImprimirResultados(delta, raiz1, raiz2);
        }

        static void ReceberEntradas(out double coeficienteA, out double coeficienteB, out double coeficienteC)
        {
            coeficienteA = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor de a: ");
            coeficienteB = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor de b: ");
            coeficienteC = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor de c: ");
        }

        static void ImprimirResultados(double delta, double? raiz1, double? raiz2)
        {
            if (delta < 0)
            {
                Console.WriteLine("Não há raízes (delta menor que zero)");
                return;
            }

            if (delta == 0)
            {
                Console.WriteLine($"Uma raiz encontrada (delta igual a zero): {raiz1}");
                return;
            }

            Console.WriteLine($"Raízes encontradas: {raiz1} e {raiz2}");
        }
}
}
