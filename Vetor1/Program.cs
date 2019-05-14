using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random ();//instancia um objeto de numeros aleatorios
            int[] vetorA = new int[10];
            int[] vetorM = new int[10];
            int x = 0;

            Console.Write("Insira um  numero que multiplicará o vetor :");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetorA.Length; i++)
            {
                //Console.WriteLine("Insira o " + (i + 1) + "º numero"); Tirei pq criei aleatoriamente
                vetorA[i] = rnd.Next(100);

            }
            for (int j = 0; j < vetorA.Length; j++)
            {
                vetorM[j] = vetorA[j] * x;
                //Parecer um vetor
                if (j == 0)
                {
                    Console.Write("(" + vetorM[j]);
                }
                if (j == 9)
                {
                    Console.Write(vetorM[j] + ")");
                }else
                Console.Write(vetorM[j] + ",");
                
            }
 
            Console.ReadKey();
        }
    }
}
