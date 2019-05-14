using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float raio;
            double pi = 3.14;

            Console.WriteLine("Qual o raio do Circulo desejado? ");
            raio = float.Parse(Console.ReadLine());


            Console.Write("A área do circulo é " + (pi * (raio * raio)) + " , e sua circunferencia é " + pi * raio);
            Console.ReadKey();
        }
    }
}
