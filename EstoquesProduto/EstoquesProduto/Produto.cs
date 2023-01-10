using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoquesProduto
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            double valorTotal = quantidade * preco;
            return valorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade = this.quantidade + quantidade;
            Console.WriteLine($"Estoque Atualizado:\nNome: {nome} | Preco: {preco} | Quantidade: {this.quantidade} | Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade = this.quantidade - quantidade;
            Console.WriteLine($"Estoque Atualizado:\nNome: {nome} | Preco: {preco} | Quantidade: {this.quantidade} | Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
