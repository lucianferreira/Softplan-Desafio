﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Desafio.Dominio.Classes
{
    public class CalculoDeJuros
    {
        public CalculoDeJuros() { }

        public double CalcularJuros(double valorInicial, double taxaJuros, int tempo)
        {
            var variante = Math.Pow(1 + taxaJuros, tempo);
            var totalJuros = valorInicial * variante;

            return totalJuros;
        }
    }
}
