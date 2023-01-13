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
        private string _nome;
        private double _preco;
        private int _quantidade;


        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null)
                {
                    _nome = value;
                }
            }
        }

        /*
            Obriga o usuário, ao instanciar essa classe, a informar os seus atributos 
        */
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            this._nome = nome;
            this._preco = preco;
        }

        public Produto() { 
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = _quantidade * _preco;
            return valorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this._quantidade = this._quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this._quantidade = this._quantidade - quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {_nome} | Quantidade: {_quantidade} unidades | Preço: R${_preco} | Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
