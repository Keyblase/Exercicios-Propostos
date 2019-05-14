using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabalhadasMes = 0 ;
            float salarioHora = 0;

            Console.WriteLine("Quantas horas o funcionario trabalhou no mes ");
            horasTrabalhadasMes = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto é o seu salario por hora ");
            salarioHora = float.Parse(Console.ReadLine());

            if(horasTrabalhadasMes > 40)
            {
                salarioHora *= 1.50f;
                Console.Write("O salario do funcionario é: R$" + salarioHora * horasTrabalhadasMes);
            }else
                Console.Write("O salario do funcionario é: R$" + salarioHora * horasTrabalhadasMes);

            Console.ReadKey();
        }
    }
}
