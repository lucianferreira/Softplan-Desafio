using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Softplan.Desafio.Servico.Interfaces;

namespace Softplan.Desafio.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CalcularJurosController : ControllerBase
    {
        private readonly ICalculoDeJuros _calculoDeJuros;
        /// <summary>
        /// Construtor Padrão 
        /// </summary>
        /// <param name="calculoDeJuros">calculo De Juros</param>
        public CalcularJurosController(ICalculoDeJuros calculoDeJuros)
        {
            _calculoDeJuros = calculoDeJuros;
        }

        /// <summary>
        /// Calcula o valor de juros compostos
        /// </summary>
        /// <param name="valorInicial">Valor inicial para o calculo</param>
        /// <param name="tempo">Quantidade de meses</param>
        /// <returns>Valor atualizado</returns>
        [Route("calculajuros")]
        [HttpGet]
        public ActionResult<double> CalculaJuros(double valorInicial, int tempo)
        {
            return _calculoDeJuros.CalcularJuros(valorInicial, tempo);
        }
    }
}