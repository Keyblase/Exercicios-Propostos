using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            float salárioFixo = 0, comissao = 0, valorVendas = 0;

            Console.WriteLine("Insira o valor do salario fixo do funcionario");
            salárioFixo = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de vendas feito  pelo funcionario");
            valorVendas = float.Parse(Console.ReadLine());

            if (salárioFixo <= 1500.00f)
            {
                comissao = 1.03f;
                Console.WriteLine("O seu salario total é" + (salárioFixo * comissao));
                Console.ReadKey();
            }
            else
            {
                comissao = 1.05f;
                Console.WriteLine("O seu salario total é" + (salárioFixo * comissao));
                Console.ReadKey();
            }
        }
    }
}
