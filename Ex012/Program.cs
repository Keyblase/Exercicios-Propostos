using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            float saldo = 0, debito = 0, credito;
            int contaCodigo = 0;

            Console.Write("Insira o numero da conta");
            contaCodigo = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor do seu saldo");
            saldo = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor do debito ");
            debito = float.Parse(Console.ReadLine());

            Console.Write("Insira o valor do credito ");
            credito = float.Parse(Console.ReadLine());


            if ((saldo + debito - credito) > 0)
            {
                Console.Write("O seu salario  é Positivo");
            }
            else
            {
                Console.Write("O seu salario  é Negativo");
            }
            Console.ReadKey();
        }
    }
}
