using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            float GrauCelsius = 0;

            Console.WriteLine("Qual a temperatura em graus Celsius:");
            GrauCelsius = float.Parse(Console.ReadLine());

            
            Console.WriteLine("O valor em graus Fahrenheit é " + ((9 * GrauCelsius) + 32) / 5 );
            Console.ReadKey();

        }
    }
}
