using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();// string para chave e valores
            //Add(key,value);
            dict.Add("C#", "COOOOLLLLL");
            dict.Add("POWER BI", "COOOOLLLLL a LOT");

            //Ver se tem um chave em particular

            Console.WriteLine(" Contém C# " + dict.ContainsKey("C#"));
            Console.WriteLine("Contem  Ruby " + dict.ContainsKey("Ruby"));

            //Itera pares de chaves e valores no dictionary
            foreach(KeyValuePair<string,string> pair in dict)
            {
                Console.WriteLine("Key :" + pair.Key.PadRight(8) + " Value :" + pair.Value);
            }

            //mostra chaves somente
            Dictionary<string, string>.KeyCollection keys = dict.Keys;

            foreach(string key in keys)
            {
                Console.WriteLine("Key :" + key);
            }

            //mostra valores somente
            Dictionary<string, string>.ValueCollection values = dict.Values;

            foreach (string value in values)
            {
                Console.WriteLine("Value :" + value);
            }

            Console.WriteLine(" Numero de itens no dicionario" + dict.Count);

            Console.ReadKey();

        }
    }
}
