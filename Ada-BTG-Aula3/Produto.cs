using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada_BTG_Aula3
{
    internal class Produto
    {
        string nome;
        double preco;
        int quantidade;

        public double ValorTotalEmEstoque()
        {
            return quantidade * preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }
    }
}
