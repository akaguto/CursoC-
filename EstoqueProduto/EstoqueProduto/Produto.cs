using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstoqueProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int QtEstoque;

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
                + Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                +", "
                + QtEstoque 
                + " unidades, Total: $ " 
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

 
    }
}
