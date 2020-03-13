using System;

namespace Softplan.Desafio.Dominio.Classes
{
    public class TaxaDeJuros
    {
        private const double _taxaJuros = .01;
        public TaxaDeJuros(){ }
        
        public double ObterTaxaDeJuros()
        {
            return _taxaJuros;
        }
    }
}
