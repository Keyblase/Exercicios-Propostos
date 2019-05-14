using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double faren;
            Console.WriteLine("Informe a temparatura em graus F : ");
            faren = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}", faren, ConvertTemp.ConverteFahrenheitToCelsius(faren));
            Console.ReadKey();
        }

        static class ConvertTemp
        {

            public static double ConverteFahrenheitToCelsius(double farenh)
            {
                return (5.0 / 9.0) * (farenh - 32);
            }
        }
    }
}

