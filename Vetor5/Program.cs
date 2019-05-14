using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] v = new int[8];
            v[0] = 5;
            v[1] = 1;
            v[2] = 4;
            v[3] = 2;
            v[4] = 7;
            v[5] = 8;
            v[6] = 3;
            v[7] = 6;
       
            for (int i = 0; i < v.Length; i++)
            {
                if(i > 0) { 
                var aux = v[i];
                v[i] = v[ i - 1];
                v[i] = aux;
                Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
