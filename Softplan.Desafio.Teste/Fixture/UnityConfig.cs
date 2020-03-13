using Softplan.Desafio.Dominio.Classes;
using Softplan.Desafio.Servico.Classes;
using Softplan.Desafio.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Softplan.Desafio.Teste.Fixture
{
    public class UnityConfig
    {
        public static void RegisterDependencies(IUnityContainer container)
        {
            container.RegisterFactory<ICalculoDeJuros>((c, type, name) => c.Resolve<ServicoDeCalculoDeJuros>());
            container.RegisterFactory<IShowMeTheCode>((c, type, name) => c.Resolve<ServicoDoShowMeTheCode>());
            container.RegisterFactory<ITaxaDeJuros>((c, type, name) => c.Resolve<ServicoDeTaxaDeJuros>());
        }
    }
}
