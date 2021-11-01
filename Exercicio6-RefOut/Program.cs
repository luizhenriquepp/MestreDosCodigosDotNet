using LibConsole;
using System;

namespace Exercicio6_RefOut
{
    class Program
    {
        static void Main()
        {
            var salario = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor do salário bruto: ");
            var valorInss = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor do INSS: ");
            var valorIr = ValidacaoEntradas<double>.RetornarValorValido("Digite o valor do IR: ");
            
            DescontarInss(ref salario, valorInss);
            DescontarIr(salario, valorIr, out var salarioLiquido);
            
            Console.WriteLine($"O salário líquido é {salarioLiquido}");
        }

        static void DescontarInss(ref double salario, double valorInss)
        {
            salario -= valorInss;
        }

        static void DescontarIr(double salario, double valorIr, out double salarioLiquido)
        {
            salarioLiquido = salario - valorIr;
        }
    }
}
