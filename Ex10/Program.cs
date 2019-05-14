using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = 0 , reajuste = 0;

            Console.WriteLine("Qual o salario do funcionario:");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o reajuste salarial em porcentagem:");
            reajuste = int.Parse(Console.ReadLine());

            Console.WriteLine("O novo salario do funcionario é R$ " + ( salario + (reajuste * salario / 100 )));
            Console.ReadKey();

        }
    }
}
