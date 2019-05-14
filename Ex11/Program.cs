using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            float cotacaoDolar = 0, ValorReais = 0;

            Console.WriteLine("Qual a cotação do dolar?:");
            cotacaoDolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual  a quantia em reais quer converter?:");
            ValorReais = float.Parse(Console.ReadLine());

            //Faz conversão se ambos os numeros forem ponto flutuante
            Console.WriteLine("O valor em dolar é R$ " + (  ValorReais / cotacaoDolar));
            Console.ReadKey();
        }
    }
}
