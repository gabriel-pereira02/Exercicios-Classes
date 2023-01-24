namespace Listas
{
    class Program{
        static void Main(string[] args){
            List<string> lista = new List<string>();
            lista.Add("Gabriel");
            lista.Add("João");
            lista.Add("André");
            lista.Insert(0, "Ana");
            foreach(string obj in lista){
                Console.WriteLine($"{obj}...");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{lista.Find(x => x[0] == 'G')}...");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"{lista.Count}");
        }
    }
}