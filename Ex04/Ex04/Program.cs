namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario = new Funcionarios();
            Console.WriteLine("Dados do Funcionario: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto pago: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do funcionário cadastrado: {funcionario}");

            Console.Write($"Aumento percentual do salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

        }
    }
}
