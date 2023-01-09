namespace CalcularAreaComOO
{
    class Program
    {
        static void Main(string[] args)
        {
            float aX = float.Parse(Console.ReadLine());
            float bX = float.Parse(Console.ReadLine());
            float cX = float.Parse(Console.ReadLine());
            Triangulo x = new Triangulo(aX, bX, cX);

            float aY = float.Parse(Console.ReadLine());
            float bY = float.Parse(Console.ReadLine());
            float cY = float.Parse(Console.ReadLine());
            Triangulo y = new Triangulo(aY, bY, cY);

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine($"Área de X = {areaX.ToString("F4")}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4")}");

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
