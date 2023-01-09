namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioA = new Funcionario(); 
            Funcionario funcionarioB = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionarioA.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioA.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionarioB.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioB.salario = float.Parse(Console.ReadLine());

            float salarioMedio = (funcionarioA.salario + funcionarioB.salario) / 2;
            Console.WriteLine($"Salário médio: {salarioMedio}");

        }
    }
}