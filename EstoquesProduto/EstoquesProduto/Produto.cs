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

        /*
            Obriga o usuário, ao instanciar essa classe, a informar os seus atributos 
        */
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = quantidade * preco;
            return valorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade = this.quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade = this.quantidade - quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {nome} | Quantidade: {quantidade} unidades | Preço: R${preco} | Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
