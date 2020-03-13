using System;

namespace Softplan.Desafio.Utilitario
{
    public static class Extensao
    {
        public static double ObterTruncado(this double value)
        {
            return Math.Truncate(value * 100) / 100;
        }

        public static string ObterFormatado(this double value)
        {
            return value.ToString("N2");
        }
    }
}
