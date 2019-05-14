using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[30];
            int numeroInformado = 0;
            int quantidade = 0;

            Console.WriteLine("Insira um numero para encontrar no vetor");
            numeroInformado = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {

                Console.WriteLine("Insira o " + (i + 1) + "º numero");
                vetor[i] = int.Parse(Console.ReadLine());

                if(numeroInformado == vetor[i])
                {
                    quantidade++;
                }

            }
            Console.WriteLine("Há " + quantidade + " numeros iguais á " + numeroInformado + " no vetor");

            Console.ReadKey();
        }
    }
}
