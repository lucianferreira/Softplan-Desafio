﻿using Softplan.Desafio.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Softplan.Desafio.Teste.Fixture
{
    public class ContainerFixture : IDisposable
    {
        private readonly IUnityContainer container = new UnityContainer();

        public ContainerFixture()
        {
            UnityConfig.RegisterDependencies(container);
            
        }

        public ICalculoDeJuros CalculoDeJuros
        {
            get
            {
                return container.Resolve<ICalculoDeJuros>();
            }
        }

        public IShowMeTheCode ShowMeTheCode
        {
            get
            {
                return container.Resolve<IShowMeTheCode>();
            }
        }

        public ITaxaDeJuros TaxaDeJuros
        {
            get
            {
                return container.Resolve<ITaxaDeJuros>();
            }
        }

        public void Dispose()
        {
            container.Dispose();
        }
    }
}
