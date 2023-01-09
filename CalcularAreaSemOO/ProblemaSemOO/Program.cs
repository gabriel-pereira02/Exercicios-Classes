using System.Globalization;

namespace CalcularAreaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            float aX = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float bX = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float cX = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            float aY = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float bY = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float cY = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float pX = (aX + bX + cX) / 2;
            float pY = (aY + bY + cY) / 2;

            double areaX = Math.Sqrt(pX*(pX-aX)*(pX-bX)*(pX-cX));
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));
            Console.WriteLine($"Área triângulo X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área triângulo Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }
        }
    }
}
