namespace ExVetor
{
    public class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudantes(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public Estudantes()
        {
            
        }

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}