using FluentAssertions;
using Softplan.Desafio.Servico.Interfaces;
using Softplan.Desafio.Teste.Fixture;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Softplan.Desafio.Teste.Testes
{
    public class TestaServicoDoShowMeTheCode : IClassFixture<ContainerFixture>
    {
        private readonly IShowMeTheCode _showMeTheCode;

        public TestaServicoDoShowMeTheCode(ContainerFixture container)
        {
            _showMeTheCode = container.ShowMeTheCode;
        }

        [Fact]
        public void ShowMeTheCodeTesteOk()
        {
            var response = _showMeTheCode.ObterEnderecoDoGithub();
            response.Should().Be("https://github.com/lucianferreira/Softplan-Desafio");
        }

        [Fact]
        public void ShowMeTheCodeTesteErro()
        {
            var response = _showMeTheCode.ObterEnderecoDoGithub();
            response.Should().NotBe("https://github.com");
            response.Should().NotBe("");
        }

    }
}
