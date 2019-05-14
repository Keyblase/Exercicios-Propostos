using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigo
{
    public class Professor :  Pessoa
    {

        private String disciplina, universidade;

        public string Disciplina { get => disciplina; set => disciplina = value; }
        public string Universidade { get => universidade; set => universidade = value; }

        public Professor() : base()
        {
           
        }

        public Professor(int id, string nome) : base(id,nome)
        {
           
        }

        public Professor(int id, string nome, DateTime dataNascimento) : base(id,nome,dataNascimento)
        {
            
        }

        public Professor(int id, string nome, DateTime dataNascimento, String disciplina) : base(id,nome,dataNascimento)
        {           
            this.Disciplina = disciplina;
        }

        public Professor(int id, string nome, char sexo, string telefone, DateTime dataNascimento, string disciplina, string universidade)
            : base(id,nome,dataNascimento,sexo)
        {          
            this.Universidade = universidade;            
        }

        
    }
}
