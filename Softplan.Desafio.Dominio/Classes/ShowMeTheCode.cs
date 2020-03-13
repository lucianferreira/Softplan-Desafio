using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Dominio.Classes
{
    public class ShowMeTheCode
    {
        private const string _endereco = "https://github.com/lucianferreira/Softplan-Desafio";
        public ShowMeTheCode() { }

        public string ObterEnderecoDoGithub()
        {
            return _endereco;
        }
    }
}
