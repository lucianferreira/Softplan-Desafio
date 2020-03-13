using Softplan.Desafio.Dominio.Classes;
using Softplan.Desafio.Servico.Interfaces;
using Softplan.Desafio.Utilitario;

namespace Softplan.Desafio.Servico.Classes
{
    public class ServicoDeCalculoDeJuros : ICalculoDeJuros
    {
        private readonly ITaxaDeJuros _taxaJuros;
        public ServicoDeCalculoDeJuros(ITaxaDeJuros taxaDeJuros) 
        {
            _taxaJuros = taxaDeJuros;
        }

        public double CalcularJuros(double valorInicial, int tempo)
        {
            var taxaJuros = _taxaJuros.ObterTaxaDeJuros();
            CalculoDeJuros calculoDeJuros = new CalculoDeJuros();
            var totalJuros = calculoDeJuros.CalcularJuros(valorInicial, taxaJuros, tempo);

            return totalJuros.ObterTruncado();
        }
    }
}
