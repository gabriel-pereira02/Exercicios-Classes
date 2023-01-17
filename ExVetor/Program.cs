namespace ExVetor
{
    class Program{
        static void Main(string[] args){
            Estudantes[] quartos = new Estudantes[10];
            Estudantes estudante;
            Console.Write("Quantos quartos serão alugados: ");
            int qtdQuartos = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtdQuartos; i++){
                Console.WriteLine($"#{i+1} Alugel -");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudante = new Estudantes(nome, email, quarto);
                quartos[quarto-1] = estudante;
            }

            for(int i = 0; i<9; i++){
                Estudantes quartoOcupado = quartos[i];
                if (quartoOcupado != null)
                {
                    Console.WriteLine($"{quartoOcupado}");
                }
            }
        }
    }
}