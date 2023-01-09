namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Pessoa pessoaA = new Pessoa();
            Console.Write("Nome: ");
            pessoaA.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaA.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Pessoa pessoaB = new Pessoa();
            Console.Write("Nome: ");
            pessoaB.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoaB.idade = int.Parse(Console.ReadLine());

            if(pessoaA.idade > pessoaB.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaA.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaB.nome}");
            }


        }
    }
}