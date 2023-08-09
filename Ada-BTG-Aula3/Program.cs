using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Ada_BTG_Aula3
{
    internal class Program
    {
//  Fazer um programa para ler os dados de um produto em estoque(nome, preço e quantidade no estoque).
//  Em seguida:

//• Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no estoque)

//• Realizar uma entrada no estoque e mostrar novamente os dados do produto

//• Realizar uma saída no estoque e mostrar novamente os dados do produto.
        static void Main(string[] args)
        {
            Produto produto = new();

            Console.WriteLine("Digite o nome do produto": );
            produto.nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto": );
            produto.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto": );
            produto.quantidade = int.Parse(Console.ReadLine());



        }
    }
}