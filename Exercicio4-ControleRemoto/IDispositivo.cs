namespace Exercicio4_ControleRemoto
{
    public interface IDispositivo
    {
        int Canal { get; }
        int Volume { get; }

        int IncrementarVolume();

        int IncrementarCanal();

        int DecrementarVolume();

        int DecrementarCanal();

        void TrocarParaCanal(int canal);

        void ImprimirDados();
    }
}
