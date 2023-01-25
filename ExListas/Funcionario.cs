namespace ExListas
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AumentarSalario(float porcentagem){
            Salario = Salario * (1+(porcentagem/100));
        }
    }
}