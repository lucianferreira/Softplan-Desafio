using Microsoft.AspNetCore.Mvc;
using Softplan.Desafio.Servico.Interfaces;

namespace Softplan.Desafio.API.Controllers
{
    /// <summary>
    /// Controller para taxa de juros
    /// </summary>
    [Route("api/")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaDeJuros _taxaDeJuros;
        /// <summary>
        /// Construtor Padrão 
        /// </summary>
        /// <param name="taxaDeJuros">Taxa de Juros</param>
        public TaxaJurosController(ITaxaDeJuros taxaDeJuros)
        {
            _taxaDeJuros = taxaDeJuros;
        }

        /// <summary>
        /// Obtem a taxa de juros
        /// </summary>
        /// <returns>Valor da taxa de juros</returns>
        [Route("taxajuros")]
        [HttpGet]
        public ActionResult<double> ObterTaxaDeJuros()
        {
            return _taxaDeJuros.ObterTaxaDeJuros();
        }
    }
}