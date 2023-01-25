namespace ExListas{
    class Program{
        static void Main(string[] args){
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            Console.Write("Quantos funcionários serão registrados? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtdFuncionarios; i++){
                Console.WriteLine($"Funcionario #{i+1}");
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o id do funcionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new Funcionario(nome, id, salario));
            }

            Console.Write("Digite o id do funcionário que tera um aumento salarial: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            bool funcionarioExiste = listaFuncionarios.Contains(listaFuncionarios.Find(x => x.Id == idFuncionario));

            if(funcionarioExiste){
                Console.Write("Digite o aumento percentual (%): ");
                float porcentagem = float.Parse(Console.ReadLine());
                listaFuncionarios.Find(x => x.Id == idFuncionario).AumentarSalario(porcentagem);

            } else{
                Console.WriteLine("Id não existente");
            }

            Console.WriteLine("Lista atualizada: ");
            for(int i = 0; i<qtdFuncionarios; i++){
                Console.WriteLine($"{listaFuncionarios[i]}");
            }

        }
    }
}