using Softplan.Desafio.Dominio.Classes;
using Softplan.Desafio.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Servico.Classes
{
    public class ServicoDoShowMeTheCode : IShowMeTheCode
    {
        public ServicoDoShowMeTheCode(){}

        public string ObterEnderecoDoGithub()
        {
            ShowMeTheCode showMeTheCode = new ShowMeTheCode();
            return showMeTheCode.ObterEnderecoDoGithub();
        }
    }
}
