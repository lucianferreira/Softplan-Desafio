using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Servico.Interfaces
{
    public interface ITaxaDeJuros
    {
        /// <summary>
        /// Obtem a taxa de juros mensal
        /// </summary>
        /// <returns>Valor mensal da taxa de juros</returns>
        double ObterTaxaDeJuros();
    }
}
