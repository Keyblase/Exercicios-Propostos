using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notaAluno = new int[5];
            int somaNota = 0, quantidadeAcimaMedia = 0, quantidadeNotas = 0;
            float mediaNota = 0;
            for (int i = 0; i < notaAluno.Length; i++)
            {
                Console.WriteLine("Insira a nota do  " + (i + 1) + "º aluno");
                notaAluno[i] = int.Parse(Console.ReadLine());
                somaNota += notaAluno[i];
                quantidadeNotas++;
            }

            mediaNota = ( somaNota / quantidadeNotas );

            for(int j = 0; j < notaAluno.Length; j++)
            {
                if(mediaNota < notaAluno[j])
                {
                    quantidadeAcimaMedia++;
                }
            }

            Console.WriteLine("A media é " + mediaNota);
            Console.WriteLine("A quantidade de notas acima da media é " + quantidadeAcimaMedia);

            Console.ReadKey();
        }
    }
}
