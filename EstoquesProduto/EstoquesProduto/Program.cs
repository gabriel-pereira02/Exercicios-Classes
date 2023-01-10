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

            Console.WriteLine($"Produto 01 - Nome: {produto1.nome} | Preço: {produto1.preco} | Quantidade: {produto1.quantidade} | Total: R${produto1.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(quantidade);

            Console.Write("Digite o número de produtos a ser removido: ");
            quantidade = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(quantidade);
        }
    }
}