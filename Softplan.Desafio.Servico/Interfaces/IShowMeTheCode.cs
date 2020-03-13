using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Servico.Interfaces
{
    public interface IShowMeTheCode
    {
        /// <summary>
        /// Retorna o endereço onde encontra-se o código fonte do projeto no Github
        /// </summary>
        /// <returns>endereço do projeto no Github</returns>
        string ObterEnderecoDoGithub();
    }
}
