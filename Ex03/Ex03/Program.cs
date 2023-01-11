namespace Ex03
{
    class Program
    {
        static void Main(string[] args) 
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Insira as dimenções do triângulo: ");
            Console.Write("Largura - ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura - ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {retangulo.Area().ToString("F2")}cm²");
            Console.WriteLine($"Perímetro: {retangulo.Perimetro().ToString("F2")}cm");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal().ToString("F2")}cm");
        }  
    }
}