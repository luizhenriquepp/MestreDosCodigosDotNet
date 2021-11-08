namespace Exercicio4_ControleRemoto
{
    class Program
    {
        static void Main()
        {
            var controleRemoto = new ControleRemoto(new Televisao());

            controleRemoto.DecrementarVolume();
            controleRemoto.DecrementarCanal();
            controleRemoto.ImprimirDados();
            controleRemoto.IncrementarVolume();
            controleRemoto.IncrementarVolume();
            controleRemoto.IncrementarVolume();
            controleRemoto.DecrementarVolume();
            controleRemoto.TrocarParaCanal(10);
            controleRemoto.IncrementarCanal();
            controleRemoto.IncrementarCanal();
            controleRemoto.DecrementarCanal();
            controleRemoto.ImprimirDados();
        }
    }
}
