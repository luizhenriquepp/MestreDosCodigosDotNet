using NUnit.Framework;

namespace CalculoBhaskara.NUnit.Test
{
    public class CalculoBhaskaraTest
    {
        [TestCase(1, -5, 6)]
        [TestCase(4, 2, -6)]
        public void DeveEncontrarDuasRaizes(double coeficienteA, double coeficienteB, double coeficienteC)
        {
            LibConsole.Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out var delta, out var raiz1, out var raiz2);

            Assert.Greater(delta, 0);
            Assert.IsNotNull(raiz1);
            Assert.IsNotNull(raiz2);
        }

        [Test]
        public void DeveCalcularDuasRaizes()
        {
            double coeficienteA = 4;
            double coeficienteB = 2;
            double coeficienteC = -6;
            
            LibConsole.Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out _, out var raiz1, out var raiz2);

            Assert.AreEqual(1, raiz1);
            Assert.AreEqual(-1.5, raiz2);
        }

        [TestCase(4, -4, 1)]
        [TestCase(1, -10, 25)]
        public void DeveEncontrarUmaRaiz(double coeficienteA, double coeficienteB, double coeficienteC)
        {
            LibConsole.Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out var delta, out var raiz1, out var raiz2);

            Assert.AreEqual(0, delta);
            Assert.IsNotNull(raiz1);
            Assert.IsNull(raiz2);
        }

        [Test]
        public void DeveCalcularUmaRaiz()
        {
            double coeficienteA = 1;
            double coeficienteB = -10;
            double coeficienteC = 25;

            LibConsole.Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out _, out var raiz1, out _);

            Assert.AreEqual(5, raiz1);
        }

        [TestCase(1, -4, 5)]
        [TestCase(7, 3, 4)]
        public void NaoDeveEncontrarRaiz(double coeficienteA, double coeficienteB, double coeficienteC)
        {
            LibConsole.Calculadora.CalcularRaizesBhaskara(coeficienteA, coeficienteB, coeficienteC, out var delta, out var raiz1, out var raiz2);

            Assert.Less(delta, 0);
            Assert.IsNull(raiz1);
            Assert.IsNull(raiz2);
        }
    }
}