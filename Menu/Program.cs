using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        public const int Saida_Programa = 0;
        public const int Ler_Arquivos = 0;
        public const int Tabuada = 2;
        public const int Calculo_Media = 3;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuario,bem vindo ao programa\n" +
                    "\n utilizando programaçao funcional " +
                    "\n Digite uma das opções abaixo" +
                    "0 - Sair do programa" +
                    "1 - Ler arquivos" +
                    "2 - executar tabuada" +
                    "3 - calcular media alunos";
                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());

                if(valor == Saida_Programa)
                {
                    break;
                }else if(valor == Ler_Arquivos)
                {
                    Console.WriteLine("============== Opção Ler Arquivos ========");
                    Ler_Arquivos.Ler(1);
                    Console.WriteLine("\n ======================");
                }else if(valor == Tabuada)
                {
                    Console.WriteLine();
                }
                else{
                    Console.WriteLine("Opção invalida");
                }
            }
        }
    }
}
