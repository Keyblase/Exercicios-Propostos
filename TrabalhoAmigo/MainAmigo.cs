using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigo
{
    class MainAmigo
    {
        static void Main(string[] args)
        {
            Amigo primeiroAmigo = new Amigo();
            Professor primeiroProfessor = new Professor();
        
            primeiroAmigo.Id = 10;
            primeiroAmigo.Apelido = "Nick";
            primeiroAmigo.Endereco = "Rua Oscar Donega";
            primeiroAmigo.Bairro = "Cristo Rei";
            
            Console.WriteLine("Insira o seu sexo");
            primeiroAmigo.Sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(primeiroAmigo.Id);

            primeiroProfessor.Nome = "Elio";
            primeiroProfessor.Universidade = "UNIP";
            Console.WriteLine(primeiroProfessor.Universidade);




        Console.ReadKey();
        }

    }
}
