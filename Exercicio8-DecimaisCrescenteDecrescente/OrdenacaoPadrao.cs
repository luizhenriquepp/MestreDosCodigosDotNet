using System.Collections.Generic;

namespace Exercicio8_DecimaisCrescenteDecrescente
{
    class OrdenacaoPadrao : IStrategy
    {
        public void Ordenar(List<double> listaDecimais)
        {
            listaDecimais.Sort();
        }
    }
}
