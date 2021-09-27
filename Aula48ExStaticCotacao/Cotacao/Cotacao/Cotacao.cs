using System;
using System.Collections.Generic;
using System.Text;

namespace Cotacao
{
    class Cotacao
    {
        public static double Dolar = 3.10;

        public static double Conversao(double valor)
        {
            return (valor + valor * 0.06) * Dolar;
        }
    }
}
