using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randon = new Random();
            int[] vetor1 = new int[15];
            int[] vetor2 = new int[15];
            int quantidadeIgual = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                //Pode Fazer assim  para o vetor1 e vetor 2:
                //Console.WriteLine("Insira o " + (i + 1) + "º numero do Vetor1");
                //vetor1[i] = int.Parse(Console.ReadLine());

                vetor1[i] = randon.Next(0, 10);
              
                vetor2[i] = randon.Next(0, 10);

                if (vetor1[i] == vetor2[i])
                {
                    quantidadeIgual++;
                }
            }
            Console.WriteLine("Há " + quantidadeIgual + " numeros iguais nos vetores");
            Console.ReadKey();
        }
    }
}
