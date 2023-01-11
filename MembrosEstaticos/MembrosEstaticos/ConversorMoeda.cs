using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    public static class ConversorMoeda
    {
        public static float CotacaoDolar;

        public static double QuantidadeDeReaisNecessarios(double dolaresDesejados)
        {
            return (dolaresDesejados*CotacaoDolar)*1.06;
        }
    }
}
