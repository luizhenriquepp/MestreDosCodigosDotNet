using System.Collections.Generic;

namespace Exercicio8_DecimaisCrescenteDecrescente
{
    class Context
    {
        private readonly IStrategy _strategy;
        private readonly List<double> _listaDecimais;

        public Context(
            IStrategy strategy,
            List<double> listaDecimais)
        {
            _strategy = strategy;
            _listaDecimais = listaDecimais;
        }

        public void Executar()
        {
            _strategy.Ordenar(_listaDecimais);
        }
    }
}
