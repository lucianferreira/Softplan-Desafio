using Softplan.Desafio.Utilitario;
using System;
using Softplan.Desafio.Dominio.Classes;
using Softplan.Desafio.Servico.Interfaces;

namespace Softplan.Desafio.Servico.Classes
{
    public class ServicoDeTaxaDeJuros : ITaxaDeJuros
    {
        public ServicoDeTaxaDeJuros()
        {  
        }

        public double ObterTaxaDeJuros()
        {
            TaxaDeJuros taxa = new TaxaDeJuros();
            return taxa.ObterTaxaDeJuros();
        }
    }
}
