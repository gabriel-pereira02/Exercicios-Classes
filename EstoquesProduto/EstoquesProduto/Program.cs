using System.Globalization;

namespace EstoquesProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto -");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto produto1 = new Produto(nome, preco);


            Console.WriteLine($"Dados do Produto - " + produto1);

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qtd);
            Console.WriteLine($"Dados do Produto - " + produto1);

            Console.Write("Digite o número de produtos a ser removido: ");
            qtd = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qtd);
            Console.WriteLine($"Dados do Produto - " + produto1);

        }
    }
}