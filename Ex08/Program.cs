using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, meses , dias , anoAtual = 2019;

            Console.WriteLine("Qual sua idade  ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual ano vc nasceu  ");
            anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual mes vc nasceu  ");
            meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual dia vc nasceu ");
            dias = int.Parse(Console.ReadLine());

            Console.Write("A sua idade em dias é : " + ( 30 * meses + 365 * (anoAtual - anos)));
            Console.ReadKey();
        }
    }
}
