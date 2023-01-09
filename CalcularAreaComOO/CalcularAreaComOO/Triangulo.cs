using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaComOO
{
    public class Triangulo
    {
        public Triangulo(float a, float b, float c)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
        }

        float a;
        float b;
        float c;

        public double CalcularArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
