using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, altura;

            Console.WriteLine("Qual a base do triangulo? ");
            lado = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura do triangulo? ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("A Hipotenusa do triangulo é " + (Math.Pow(2,lado) + Math.Pow(altura,2)));
            Console.ReadKey();
        }
    }
}
