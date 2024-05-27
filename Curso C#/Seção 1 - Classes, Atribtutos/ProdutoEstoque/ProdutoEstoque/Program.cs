using System;
using System.Globalization;

namespace ProdutoEstoque {
    class Program {
        static void Main(string[] args) {           
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}