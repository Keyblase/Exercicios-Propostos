using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasgSetTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HashSet<int> smallPrimeNumbers = new HashSet<int>();
             List<int> intList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
             HashSet<int> numbers = new HashSet<int>(intList);
             bool sucesso = smallPrimeNumbers.Add(2);
             if (sucesso)
             {

             }*/

            //combina 2 coleçoes sem duplicatatas

            List<string> colors = new List<string> { "red", "orange", "yellow" };
            string[] moreColors = { "orange", "yellow", "green", "blue", "violet" };

            HashSet<string> combinacao = new HashSet<string>(colors);

            combinacao.UnionWith(moreColors);//UnionWith tira os duplicados das palavras em comum
            foreach (string color in combinacao)
            {
                Console.WriteLine(" As cores combinadas sem repetição são " + color);
            }

            HashSet<string> interseccao = new HashSet<string>(colors);
            interseccao.IntersectWith(moreColors);

            foreach(string moreColor in colors)
            {
                Console.WriteLine(" As cores que estão em comum são " + moreColor);
            }

            Queue<int> queue = new Queue<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 17 });
            HashSet<int> unique = new HashSet<int> { 1, 3, 5, 7, 9, 11, 13, 15 };
            unique.ExceptWith(queue);//remove todos os itens em comum

            foreach (int n in unique)
            {
                Console.WriteLine(n.ToString() + "remove itens");
            }
            Console.WriteLine(" \n");

            Stack<int> stackone = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            Stack<int> stacktwo = new Stack<int>(new int[] { 2, 4, 6, 7, 8 , 10, 12 });
            HashSet<int> nonoverlapping = new HashSet<int>(stackone);
            nonoverlapping.SymmetricExceptWith(stacktwo);//coleta itens de uma coleçao e nao na outra , nao sobrepostos(tem em um e nao no outro)

            foreach (int n in nonoverlapping)
            {
                Console.WriteLine(n.ToString());
            }

            Console.ReadKey();
        }
    }
}
