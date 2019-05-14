using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] vetorQ = new uint[5];
            uint maior = 0, menor = 0;
            int posMaior = 0, posMenor = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "º numero do elemento");
                vetorQ[i] = uint.Parse(Console.ReadLine());

                if (vetorQ[i] < menor)
                {
                    menor = vetorQ[i];
                    posMenor = i;
                }
                else if (vetorQ[i] > maior)
                {
                    maior = vetorQ[i];
                    posMaior = i;
                }
            }
            Array.Sort(vetorQ);
             maior = (uint)vetorQ.GetUpperBound(0);
             menor = (uint)vetorQ.GetLowerBound(0);           
            Console.WriteLine("Menor " + vetorQ[menor].ToString());
            Console.WriteLine("A posição do menor valor é " + posMenor);
            Console.WriteLine("Maior " + vetorQ[maior].ToString());
            Console.WriteLine("A posição do menor valor é " + posMaior);
            Console.ReadKey();
        }
    }
}
