using FluentAssertions;
using Softplan.Desafio.Teste.Contexto;
using Softplan.Desafio.Teste.Fixture;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Desafio.Teste.Testes
{
    public class TestaControllerShowMeTheCode : IClassFixture<ContainerFixture>
    {
        private readonly ContextoTeste _contextoTeste;
        public TestaControllerShowMeTheCode()
        {
            _contextoTeste = new ContextoTeste();
        }

        [Fact]
        public async Task ObterEnderecoDoGithubOK()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ObterEnderecoDoGithubContentType()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/showmethecode");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}
