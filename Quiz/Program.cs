using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {

        public static int pontos = 0;
        public struct Ranking
        {
            public string[] nomePassado;
            public int[] pontos;

            public static implicit operator Ranking(string v)
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine("========== Desafio de Quiz Saulo ==========");
            Console.WriteLine("Let´s get start !!!");
            Console.WriteLine(" Primeiramento caro Player , diga seu grandioso nome :");
            nome = Console.ReadLine();

            Console.WriteLine(" Vamos começar nosso jogo ");
            Console.WriteLine("Selecionar a alternativa correta:");
            randonAsk();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Você " + nome.ToString() + "fez " + pontos);

                Ranking ranking = new Ranking();
                ranking.nomePassado[i] = nome;
                ranking.pontos[i] = pontos;
                Console.ReadKey();
            }

        }

        public static void randonAsk()
        {
            bool continuar = true;// nao implementado
            int perguntas = 0;
            int[] perguntaAtual = new int[7];
            bool[] passouNaPergunta = new bool[8];
            do
            {               
                Random random = new Random();
                int numeroPergunta = random.Next(1, 8);
                
                for (int j = 1; j < perguntaAtual.Length; j++)
                {

                    if (numeroPergunta == 1 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            primeiraPergunta(pontos);
                            passouNaPergunta[0] = true;
                            perguntas += 1;
                            continue;
                        }

                    }
                    else if (numeroPergunta == 2 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            segundaraPergunta(pontos);
                            passouNaPergunta[2] = true;
                            perguntas += 1;
                            continue;
                        }
                    }
                    else if (numeroPergunta == 3 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            terceiraaPergunta(pontos);
                            passouNaPergunta[3] = true;
                            perguntas += 1;
                            continue;
                        }
                    }
                    else if (numeroPergunta == 4 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            quartaPergunta(pontos);
                            passouNaPergunta[4] = true;
                            perguntas += 1;
                            continue;
                        }
                    }
                    else if (numeroPergunta == 5 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            quintaPergunta(pontos);
                            passouNaPergunta[5] = true;
                            perguntas += 1;
                            continue;
                        }
                    }
                    else if (numeroPergunta == 6 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            sextaPergunta(pontos);
                            passouNaPergunta[6] = true;
                            perguntas += 1;
                            continue;
                        }
                    }
                    else if (numeroPergunta == 7 && passouNaPergunta[j] == false)
                    {
                        int vezesPassada = 0;
                        vezesPassada++;
                        int[] valor = new int[1];
                        valor[0] = vezesPassada;
                        if (valor[0] < 2)
                        {
                            setimaPergunta(pontos);
                            passouNaPergunta[7] = true;
                            perguntas += 1;
                            continue;
                        }
                    }

                }
            } while (continuar == true || perguntas == 7);
        }

        public static int primeiraPergunta(int pontos)
        {
            Console.WriteLine("Qual foi a Joia do Infinito que apareceu no segundo filme do Thor?");
            Console.WriteLine("A) Alma");
            Console.WriteLine("B) Mente");
            Console.WriteLine("C) Poder");
            Console.WriteLine("D) Espaço");
            Console.WriteLine("E) Realidade ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "E")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int segundaraPergunta(int pontos)
        {
            Console.WriteLine("Em qual filme Capitão América perde seu escudo oficial?");
            Console.WriteLine("A) Capitão América: Guerra Civil");
            Console.WriteLine("B) Thor ragnarok");
            Console.WriteLine("C) Avengers: Era de Ultron");
            Console.WriteLine("D) Homem de Ferro 2");
            Console.WriteLine("E) O incrivel Hulk  ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "A")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int terceiraaPergunta(int pontos)
        {
            Console.WriteLine("Quem foi que f@! #$%(estragou o plano) para derrotar o Thanos?");
            Console.WriteLine("A) O Miranha");
            Console.WriteLine("B) Peter Quill");
            Console.WriteLine("C) Senhor das Estrelas");
            Console.WriteLine("D) Gamora");
            Console.WriteLine("E) Doutor Estranho ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "B")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int quartaPergunta(int pontos)
        {
            Console.WriteLine("O Doutor Estranho era...");
            Console.WriteLine("A) Neurocirurgião");
            Console.WriteLine("B) Médico");
            Console.WriteLine("C) Cirurgião plástico");
            Console.WriteLine("D) Cirurgião batriatrico");
            Console.WriteLine("E) Enfermeiro ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "A")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int quintaPergunta(int pontos)
        {
            Console.WriteLine("Que dia o maior herói da Marvel Stan Lee morreu? (homenagem)");
            Console.WriteLine("A) 2 de dezembro de 2018");
            Console.WriteLine("B) 8 de janeiro de 2019");
            Console.WriteLine("C) 15 de dezembro de 2018");
            Console.WriteLine("D) 20 de janeiro de 2019");
            Console.WriteLine("E) 12 de novembro de 2018 ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "E")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int sextaPergunta(int pontos)
        {
            Console.WriteLine("Qual herói o Thanos tem mais medo?");
            Console.WriteLine("A) Homem de Ferro");
            Console.WriteLine("B) Gamora");
            Console.WriteLine("C) Capitão América");
            Console.WriteLine("D) O Miranha");
            Console.WriteLine("E) Capitã Mar-vell ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "A")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }

        public static int setimaPergunta(int pontos)
        {
            Console.WriteLine("Quem morreu no filme Guerra Infinita?");
            Console.WriteLine("A) Gamora, Loki, Senhor das estrela, Visão, Pantera Negra, Grott, Feiticeira, Buck, Doutor Estranho");
            Console.WriteLine("B) 50% da população do universo");
            Console.WriteLine("C) Loki");
            Console.WriteLine("D) Thor");
            Console.WriteLine("E) Capitã Mar-vell ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();

            if (opcaoEscolhida == "B")
            {
                pontos += 1;
                return pontos;
            }
            else
                Console.WriteLine("Resposta errada, mais sorte na proxima!");
            return pontos;
        }
    }
}