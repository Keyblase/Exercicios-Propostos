using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[20];

            for (int i = 0; i < vetor.Length; i++)
            {

                Console.WriteLine("Insira o " + (i + 1) + "º numero");
                vetor[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("O dado invertido fica :");

            for (int j = vetor.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(vetor[j ]);
            }
            Console.ReadKey();
        }
    }
}
