namespace Exercicio4_ControleRemoto
{
    public class ControleRemoto
    {
        protected IDispositivo Dispositivo { get; set; }

        public ControleRemoto(IDispositivo dispositivo)
        {
            Dispositivo = dispositivo;
        }

        public int IncrementarVolume() => Dispositivo.IncrementarVolume();

        public int IncrementarCanal() => Dispositivo.IncrementarCanal();

        public int DecrementarVolume() => Dispositivo.DecrementarVolume();

        public int DecrementarCanal() => Dispositivo.DecrementarCanal();

        public void TrocarParaCanal(int canal) => Dispositivo.TrocarParaCanal(canal);

        public void ImprimirDados() => Dispositivo.ImprimirDados();
    }
}
