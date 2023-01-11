using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            ConversorMoeda.CotacaoDolar = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double dolaresDesejados = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor a ser pago em reais: R${ConversorMoeda.QuantidadeDeReaisNecessarios(dolaresDesejados).ToString("F2")}");
        }
    }
}