namespace ExListas{
    class Program{
        static void Main(string[] args){
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            Console.Write("Quantos funcionários serão registrados? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtdFuncionarios; i++){
                Console.WriteLine($"Funcionario #{i+1}");
                Console.WriteLine("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new Funcionario(nome, id, salario));
            }
        }
    }
}