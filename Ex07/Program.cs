using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float custoFabrica = 0 , porcentagemDistribuidor = 1.28f , impostos = 1.45f ;

            Console.WriteLine("Qual o custo de fabrica ");
            custoFabrica = float.Parse(Console.ReadLine());

            //Impostos
            custoFabrica *= impostos;
            //Porcentagem Distribuidor
            //custoFabrica *= porcentagemDistribuidor

            Console.Write("O  custo final pro consumidor é: R$" + (custoFabrica + (custoFabrica * impostos)));

            Console.ReadKey();
        }
    }
}
