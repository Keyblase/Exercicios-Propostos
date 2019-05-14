using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        private static int op;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Treinando alguns metodos de String");
                Console.WriteLine("1 - addLine()");
                Console.WriteLine("2 - searchWord()");
                Console.WriteLine("3 - searchingNumberOnDigit()");
                Console.WriteLine("4 - SepareNumbers()");
                Console.WriteLine("5 - joinString()");
                 int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            addLine();
                            break;
                        }
                    case 2:
                        {
                            searchWord();
                            break;
                        }
                    case 3:
                        {
                            searchingNumberOnDigit();
                            break;
                        }
                    case 4:
                        {
                            SepareNumbers();
                            break;
                        }
                    case 5:
                        {
                            joinString();
                            break;
                        }
                    default:
                        {
                            return;
                        }



                } 
            } while (op != 0);
        }           

        public static bool isAllDigits(string raw)
        {
            string s = raw.Trim();//ignora espaços em branco 

            if (s.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]) == false) return false;
            }
            return true;
        }

        public static void searchingNumberOnDigit()
        {
            Console.WriteLine("Insira um numero inteiro ");
            string s = Console.ReadLine();

            if (!isAllDigits(s)) Console.WriteLine("EIII isso nao e um numero");
            else
            {
                int n = int.Parse(s);
            }
        }

        public static void addLine()
        {
            Console.WriteLine(" Cada linha que você inserir será adicionada a uma sentença até que voce insira Exit ou Quit");
            string sentence = "";
            for (; ; )
            {
                Console.WriteLine("Insira uma sentença");
                string line = Console.ReadLine();
                string[] terms = { "EXIT", "exit", "QUIT", "quit" };

                bool quitting = false;
                foreach (string term in terms)
                {
                    //SAIR SO LAÇO FOR SE VOCE TIVER UMA COMBINAÇÃO
                    if (String.Compare(line, term) == 0)
                    {
                        quitting = true;
                    }
                }
                if (quitting == true)
                {
                    break;
                }
                sentence = string.Concat(sentence, line);
                Console.WriteLine("\n você inseriu :" + sentence);
            }

            Console.WriteLine("\n total que  inseriu :" + sentence);
        }

        public static void searchWord()
        {
            string favoriteFood = "onelunchonehour";
            char[] charsToLookFor = { 'o', 'n', 'e' };
            int indexOfFistFound = favoriteFood.IndexOfAny(charsToLookFor);//LastIndexof acha o ultima ocorrencia,LastIndexOfAny igual ao 
                                                                           //indexOfAny mas comeca do final da string
            Console.WriteLine(indexOfFistFound);

            if (favoriteFood.Contains("one"))
            {
                Console.WriteLine(" O que importa");
                Console.WriteLine(favoriteFood.Substring(0, favoriteFood.Length));
            }

            bool notThere = string.IsNullOrEmpty(favoriteFood);//falso
        }

        public static void SepareNumbers()
        {

            Console.WriteLine("Insira numeros separados por virgula");
            string input = Console.ReadLine();

            char[] dividers = { ',', ' ' };
            string[] segments = input.Split(dividers);
            int sum = 0;
            foreach (string ss in segments)
            {
                if (input.Length > 0)
                {
                    if (isAllDigits(ss))
                    {
                        int num = 0;
                        if (Int32.TryParse(input, out num))
                        {
                            Console.WriteLine("Numero seguinte  = {0}", num);
                            sum += num;
                        }
                    }
                }
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        public static void joinString()
        {
            string[] family = { "Nicolas", "Ana" };
            string theParents = string.Join(",", family);
            StringBuilder stb;
        }
    }
}
