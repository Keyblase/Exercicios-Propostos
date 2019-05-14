using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int CarrosVendidos = 0;
            float ValorTotalVendas1Funcionario = 0, salarioFixo = 0 , ValorPorCarroVendido = 0;

            Console.WriteLine("Quantos carros foram vendidos? ");
            CarrosVendidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual  foi o total de vendas desse funcionario");
            ValorTotalVendas1Funcionario = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o salario fixo");
            salarioFixo = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual  o valor recebido por funcionario por venda");
            ValorPorCarroVendido = float.Parse(Console.ReadLine());

            //Faz conversão se ambos os numeros forem ponto flutuante

            Console.WriteLine("O salário é R$ " + salarioFixo + ValorPorCarroVendido + (ValorTotalVendas1Funcionario * 0.95f));
            Console.WriteLine("O valor em dolar é R$ " );
            Console.ReadKey();
        }
    }
}
