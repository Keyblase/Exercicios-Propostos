using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randon = new Random();
            int[] codig = new int[5] , preco = new int[5], codigCliente = new int[5], pedidoCodigo = new int[5],pedidoQuantidade = new int[5];

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Insira o " + (i + 1) + "º codigo do produto");
                codig[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o " + (i + 1) + "º preço do produto");
                preco[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira a quantidade do produto");
                pedidoQuantidade[i] = int.Parse(Console.ReadLine());

                codigCliente[i] = randon.Next(1, 100);
                pedidoCodigo[i] = randon.Next(1, 50);

                Console.WriteLine("Há " + pedidoQuantidade[i] + " de itens");
                Console.WriteLine("Itens do pedido :");
                Console.WriteLine("Codigo do pedido :" + codig[i]);
                Console.WriteLine("Quantidade do produto :" + pedidoQuantidade[i]);
                Console.WriteLine("Valor unitario do produto :" + preco[i]);
                Console.WriteLine("Valor total do produto :" + preco[i] * pedidoQuantidade[i]);
            }
            Console.ReadKey();
        }
    }
}
