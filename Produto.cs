using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int QntEstoque;

        public double ValorTotal()
        {
            return  Preco * QntEstoque;
        }
        public void AdcProduto(int quantidade)
        {
            QntEstoque = QntEstoque + quantidade;

        }

        public void RemoverProduto(int quantidade)
        {
            QntEstoque = QntEstoque - quantidade;
        }


        public override string ToString()
        {
            return Nome + ", " + Preco + ", " + QntEstoque + ", " + ValorTotal().ToString();
        }

        
    }
}
