using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] vetorTemperatura = new float[365];//quantidade de dias, por isso um vetor com 365 espaços
            int  quantidade = 0 , vezesQuePassou = 0;
            float somaTemperaturaDia = 0;

            for (int i = 0; i < vetorTemperatura.Length; i++)
            {
                Console.WriteLine("Insira a " + (i + 1) + "ª temperatura");
                vetorTemperatura[i] = float.Parse(Console.ReadLine());

                somaTemperaturaDia += vetorTemperatura[i];
                vezesQuePassou++;
            }
            //Verifica Apartir do vetor pego, o indice que tem o maior e menor valor
            Array.Sort(vetorTemperatura);
            int maior = vetorTemperatura.GetUpperBound(0);
            int menor = vetorTemperatura.GetLowerBound(0);
            
            Console.WriteLine("A maior temperatura no vetor é " + vetorTemperatura[maior].ToString());
            Console.WriteLine("A maior temperatura no vetor é " + vetorTemperatura[menor].ToString());

            float mediaTemperaturaAnual = somaTemperaturaDia / vezesQuePassou;

            for (int j = vetorTemperatura.Length - 1; j >= 0; j--)
            {
                if (mediaTemperaturaAnual > vetorTemperatura[j])
                {
                    quantidade++;
                }
            }         
            Console.WriteLine("A  temperatura media do ano é " + mediaTemperaturaAnual);
            Console.WriteLine("A  quantidade de dias que foi a temperatura inferior foi  " + quantidade + " dias");

            Console.ReadKey();
        }
    }
}

