using Exercicio3;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            
            
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade no estoque: ");
            p1.QntEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p1}");

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            p1.AdcProduto(qnt);

            Console.WriteLine($"Dados do produto: {p1}");


            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido ao estoque: ");
            int qnt1 = int.Parse(Console.ReadLine());
            p1.RemoverProduto(qnt1);

            Console.WriteLine($"Dados do produto: {p1}");
        }
    }
}