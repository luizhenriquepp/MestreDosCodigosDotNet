using System;

namespace Exercicio1
{
    static class Calculadora
    {
        public static double Somar(double valorA, double valorB)
        {
            return valorA + valorB;
        }

        public static double Subtrair(double valorA, double valorB)
        {
            return valorA - valorB;
        }

        public static double Dividir(double valorA, double valorB)
        {
            if (valorA == 0)
                throw new ArgumentException("Não é possível dividir por zero. Por favor, informe um valor válido.");

            return valorB / valorA;
        }

        public static double Multiplicar(double valorA, double valorB)
        {
            return valorA * valorB;
        }

        public static bool NumeroPar(int valor)
        {
            return valor % 2 == 0;
        }
    }
}
