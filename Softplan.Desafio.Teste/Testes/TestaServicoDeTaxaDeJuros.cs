using FluentAssertions;
using Softplan.Desafio.Servico.Interfaces;
using Softplan.Desafio.Teste.Fixture;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Softplan.Desafio.Teste.Testes
{
    public class TestaServicoDeTaxaDeJuros : IClassFixture<ContainerFixture>
    {
        private readonly ITaxaDeJuros _taxaDeJuros;

        public TestaServicoDeTaxaDeJuros(ContainerFixture container)
        {
            _taxaDeJuros = container.TaxaDeJuros;
        }

        [Fact]
        public void TaxaDeJurosTesteOk()
        {
            var response = _taxaDeJuros.ObterTaxaDeJuros();
            response.Should().Be(.01);
        }

        [Fact]
        public void TaxaDeJurosTesteErro()
        {
            var response = _taxaDeJuros.ObterTaxaDeJuros();
            response.Should().NotBe(0);
            response.Should().NotBe(.02);
        }
    }
}
