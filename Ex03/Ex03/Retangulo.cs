using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Altura + 2 * Largura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2)+Math.Pow(Largura, 2));
        }
    }
}
