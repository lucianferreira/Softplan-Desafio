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
    public class TestaControllerTaxaJuros : IClassFixture<ContainerFixture>
    {
        private readonly ContextoTeste _contextoTeste;

        public TestaControllerTaxaJuros()
        {
            _contextoTeste = new ContextoTeste();
        }

        [Fact]
        public async Task ObterTaxaDeJurosTesteOk()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ObterTaxaDeJurosTesteContentType()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }
    }
}
