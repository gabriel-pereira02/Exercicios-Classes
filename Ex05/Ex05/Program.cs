namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno01 = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno01.Nome = Console.ReadLine();
            Console.WriteLine("Insira suas três notas: ");
            aluno01.NotaA = float.Parse(Console.ReadLine());
            aluno01.NotaB = float.Parse(Console.ReadLine());
            aluno01.NotaC = float.Parse(Console.ReadLine());

            float notaFinal = aluno01.NotaFinal();

            if (aluno01.Aprovado().Equals(true))
            {
                Console.WriteLine($"NOTA FINAL - {notaFinal}");
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL - {notaFinal}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"PONTOS RESTANTES - {aluno01.Restante()}");
            }
        }
    }
}