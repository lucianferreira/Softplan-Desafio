﻿using FluentAssertions;
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
    public class TestaControllerCalcularJuros : IClassFixture<ContainerFixture>
    {
        private readonly ContextoTeste _contextoTeste;
        public TestaControllerCalcularJuros()
        {
            _contextoTeste = new ContextoTeste();
        }

        [Fact]
        public async Task CalculaJurosTesteOK()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/calculajuros?valorInicial=100&tempo=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CalculaJurosTesteContentType()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/calculajuros?valorInicial=100&tempo=5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }

        [Fact]
        public async Task CalculaJurosTesteBadRequestValorInicial()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/calculajuros?valorInicial=aaa&tempo=5");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task CalculaJurosTesteBadRequestTempo()
        {
            var response = await _contextoTeste.Client.GetAsync("/api/calculajuros?valorInicial=100&tempo=aaa");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
