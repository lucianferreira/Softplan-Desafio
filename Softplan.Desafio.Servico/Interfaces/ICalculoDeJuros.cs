using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Servico.Interfaces
{
    public interface ICalculoDeJuros
    {
        /// <summary>
        /// Calcula a taxa de juros
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="tempo">Quantidade de meses para aplicação do juros</param>
        /// <returns>Valor corrigido com a taxa de juros aplicada</returns>
        double CalcularJuros(double valorInicial, int tempo);
    }
}
