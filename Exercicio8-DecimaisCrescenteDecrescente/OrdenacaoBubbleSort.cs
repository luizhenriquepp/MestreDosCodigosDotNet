using System.Collections.Generic;

namespace Exercicio8_DecimaisCrescenteDecrescente
{
    class OrdenacaoBubbleSort : IStrategy
    {
        public void Ordenar(List<double> listaDecimais)
        {
            for (int i = 0; i < listaDecimais.Count; i++)
                for (int j = i + 1; j < listaDecimais.Count; j++)
                    if (listaDecimais[j] < listaDecimais[i])
                        TrocarPosicoes(listaDecimais, i, j);
        }

        private void TrocarPosicoes(List<double> listaDecimais, int posicaoInicial, int posicaoFinal)
        {
            var backupValorInicial = listaDecimais[posicaoInicial];
            listaDecimais[posicaoInicial] = listaDecimais[posicaoFinal];
            listaDecimais[posicaoFinal] = backupValorInicial;
        }
    }
}
