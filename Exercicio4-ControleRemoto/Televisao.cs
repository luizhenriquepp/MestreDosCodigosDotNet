using System;

namespace Exercicio4_ControleRemoto
{
    public class Televisao : IDispositivo
    {
        public int Canal { get; private set; }
        public int Volume { get; private set; }

        public int IncrementarVolume() => ++Volume;

        public int IncrementarCanal() => ++Canal;

        public int DecrementarVolume()
        {
            if (Volume > 0)
              Volume--;

            return Volume;
        }

        public int DecrementarCanal()
        {
            if (Canal > 0)
                Canal--;

            return Canal;
        }

        public void TrocarParaCanal(int canal)
        {
            if (canal >= 0)
                Canal = canal;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Dados da televisão");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Canal: {Canal}");
        }
    }
}
