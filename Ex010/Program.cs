using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura = 0 ,peso_ideal = 0; // faltou dar entrada no tipo da variavel
            string nome = Console.ReadLine(); // faltou o tipo de dados e ponto e virgula
            char sexo = Convert.ToChar(Console.ReadLine());     // faltou o tipo de dados e a conversão 

            if (sexo == 'M') // faltou ter 2 iguais // faltou aspas simples
            { 
                peso_ideal = (72.7f * altura) - 58.0f;// faltou add f de float, indicar o tipo
                Console.Write("Seu peso Ideal é: ", peso_ideal);//Escrever o peso no if , se ficar fora o item pode se ter valores errados
            }
            else
            {
                peso_ideal = (62.1f * altura) - 44.7f;//faltou add f de float e ele escreveu um caractere de traço maior do q o normal
                Console.Write("Seu peso Ideal é: ", peso_ideal);//Escrever o peso no if , se ficar fora o item pode se ter valores errados
            }
        }
    }
}
