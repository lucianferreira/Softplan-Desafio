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
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IShowMeTheCode _showMeTheCode;
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="showMeTheCode">show Me The Code</param>
        public ShowMeTheCodeController(IShowMeTheCode showMeTheCode)
        {
            _showMeTheCode = showMeTheCode;
        }

        /// <summary>
        /// Retorna o endereço onde encontra-se o código fonte do projeto no Github
        /// </summary>
        /// <returns>endereço do projeto no Github</returns>
        [Route("showmethecode")]
        [HttpGet]
        public ActionResult<string> ObterEnderecoDoGithub()
        {
            return _showMeTheCode.ObterEnderecoDoGithub();
        }
    }
}