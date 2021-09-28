using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstoqueProduto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int QtEstoque { get; private set; }

        public Produto(string nome, double preco, int qtEstoque)
        {
            _nome = nome;
            Preco = preco;
            QtEstoque = qtEstoque;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }

       
        public double ValorTotalEstoque()
        {
            return QtEstoque * Preco;
        }

        public void AddProdutos(int quantity)
        {
            QtEstoque += quantity;
        }

        public void RmProdutos(int quantity)
        {
            QtEstoque -= quantity;
        }

        public override string ToString()
        {
            return "Dados do Produto: "
                + _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QtEstoque
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
