namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;
            Console.Write("Insira nome do titular: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Insira o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Haverá deposito inicial? [S/N] ");
            string opt = Console.ReadLine();
            if (opt == "S")
            {
                Console.Write("Insira o deposito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numConta, nomeTitular, saldoInicial);
            }
            else
            {
                contaBancaria = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine($"Dados da Conta: {contaBancaria}");

            Console.Write("Insira a quantidade que será depositada: ");
            double dinheiro = double.Parse(Console.ReadLine());

            contaBancaria.Depositar(dinheiro);

            Console.Write("Insira a quantidade que será sacada: ");
            dinheiro = double.Parse(Console.ReadLine());
            
            contaBancaria.Sacar(dinheiro);
        }
    }
}