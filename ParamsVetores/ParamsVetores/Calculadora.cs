using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsVetores
{
    public static class Calculadora
    {
        public static double Soma(params int[] num)
        {
            double soma = 0;
            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }
            return soma;
        }
    }
}
