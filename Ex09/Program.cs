using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            float eleitores = 0, votosBranco = 0, votosNulo = 0, votosValidosTotal;
            float votosBrancoTotal = 0, votosNuloTotal = 0;

            Console.WriteLine("Qual foi o total de eleitores do municipio:");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o total de eleitores do  do municipio que votaram branco:");
            votosBranco = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o total de eleitores do municipio que votaram nulo:");
            votosNulo = int.Parse(Console.ReadLine());

            votosValidosTotal =  eleitores - votosNulo;

            votosBrancoTotal =  (votosBranco / votosValidosTotal) * 100 ;
            votosNuloTotal = (votosNulo / votosValidosTotal) * 100;

            Console.WriteLine(" a quantidade de votos validos é " + votosValidosTotal);
            Console.WriteLine(" a porcentagem de votos brancos é " + votosBrancoTotal + "%");
            Console.WriteLine(" a porcentagem de votos nulos é " + votosNuloTotal + "%");
            Console.ReadKey();
        }
    }
}
