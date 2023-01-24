namespace LacosForeach
{
    class Program{
        static void Main(string[] args){
            string[] arr = new string[]{"João", "Maria", "Gabriel"};
            foreach (string nomes in arr)
            {
                Console.Write($"{nomes}...");
            }
        }
    }
}