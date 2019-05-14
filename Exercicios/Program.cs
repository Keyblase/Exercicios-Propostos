using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("Qual o seu nome?: ");
            nome = Console.ReadLine();

            int idade = pergunta("Qual a sua idade atual?: ");
            int ano = pergunta("Qual ano você se casou?");

            Console.Write(nome + " , você tinha " + (ano - idade) + " quando se casou em " + ano);
            Console.ReadKey();
        }

        private static int pergunta(String mensagem)
        {

            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}
