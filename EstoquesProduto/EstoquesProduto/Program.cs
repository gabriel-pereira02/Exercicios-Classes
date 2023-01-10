using System.Globalization;

namespace EstoquesProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Console.WriteLine("Entre os dados do produto -");
            Console.Write("Nome: ");
            produto1.nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            produto1.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto - " + produto1);

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(quantidade);
            Console.WriteLine($"Dados do Produto - " + produto1);

            Console.Write("Digite o número de produtos a ser removido: ");
            quantidade = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(quantidade);
            Console.WriteLine($"Dados do Produto - " + produto1);
        }
    }
}