using FluentAssertions;
using Softplan.Desafio.Servico.Interfaces;
using Softplan.Desafio.Teste.Fixture;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Softplan.Desafio.Teste.Testes
{
    public class TestaServicoDeCalculoDeJuros : IClassFixture<ContainerFixture>
    {
        private readonly ICalculoDeJuros _calculoDeJuros;

        public TestaServicoDeCalculoDeJuros(ContainerFixture container)
        {
            _calculoDeJuros = container.CalculoDeJuros;
        }

        [Fact]
        public void CalcularJurosTesteOk()
        {
            var response = _calculoDeJuros.CalcularJuros(100, 5);
            response.Should().Be(105.1);
        }

        [Fact]
        public void CalcularJurosTesteErro()
        {
            var response = _calculoDeJuros.CalcularJuros(100, 5);
            response.Should().NotBe(100);
        }
    }
}
