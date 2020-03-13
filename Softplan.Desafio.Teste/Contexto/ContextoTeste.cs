using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Softplan.Desafio.API;
using System.Net.Http;

namespace Softplan.Desafio.Teste.Contexto
{
    public class ContextoTeste
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public ContextoTeste()
        {
            SetupClient();
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = _server.CreateClient();
        }
    }
}
