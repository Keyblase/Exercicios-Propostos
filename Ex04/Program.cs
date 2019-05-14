using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado, altura;

            Console.WriteLine("Qual a base do triangulo? ");
            lado = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura do triangulo? ");
            altura = float.Parse(Console.ReadLine());

            Console.Write("A área do triangulo é " + ((lado * altura)/2));
            Console.ReadKey();
        }
    }
}
