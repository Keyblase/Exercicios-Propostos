using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randonNumero = new Random();
            int[] vet = new int[5];
            int[] posicao = new int[5];
            bool existeRepetido = false;

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = randonNumero.Next(0, 10);
                Console.WriteLine("vetor" + vet[i]);

                for (int j = 0; j < vet.Length; j++)
                {

                    if (vet[i] == vet[j] && i != j)
                    {
                        existeRepetido = true;
                        posicao[j] = i;
                        Console.WriteLine(posicao[j]);
                        break;

                    }

                }
            }

            Console.WriteLine(" Numeros Repetidos : " + existeRepetido);
            Console.ReadKey();
        }
    }
}
