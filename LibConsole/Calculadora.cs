using System;

namespace LibConsole
{
    public static class Calculadora
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
            return Multiplo(valor, 2);
        }

        public static bool Multiplo(int valor, int valorBase)
        {
            return valor % valorBase == 0;
        }

        public static void CalcularRaizesBhaskara(double coeficienteA, double coeficienteB, double coeficienteC, out double delta, out double? raiz1, out double? raiz2)
        {
            raiz1 = null;
            raiz2 = null;
            delta = Math.Pow(coeficienteB, 2) - 4 * coeficienteA * coeficienteC;

            if (delta < 0)
                return;

            raiz1 = (-coeficienteB + Math.Sqrt(delta)) / (2 * coeficienteA);

            if (delta == 0)
                return;

            raiz2 = (-coeficienteB - Math.Sqrt(delta)) / (2 * coeficienteA);
        }
    }
}
