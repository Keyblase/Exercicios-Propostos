using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigo
{
    public abstract class Pessoa
    {

        private int id;
        private String nome;
        private DateTime dataNascimento;
        private char sexo;
        private String telefone;

        //Encapsuladores
        public char Sexo { get => sexo; set => sexo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
      

        /// <summary>
        /// Metodos Pessoa 
        /// </summary>

        #region
        public Pessoa()
        {

        }

        public Pessoa(int id)
        {

        }
        public Pessoa(int id, String nome)
        {

        }
        public Pessoa(int id, String nome, DateTime dataNascimento)
        {

        }

        protected Pessoa(int id, string nome, DateTime dataNascimento, char sexo)
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;         
        }

        protected Pessoa(int id, string nome, DateTime dataNascimento, char sexo, string telefone)//essas variaveis entre parentese são passadas
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.telefone = telefone;
        }
        #endregion 

        // getIdade , difere dos outros
        public int getIdade()
        {
            DateTime agora = DateTime.Now.Date;
            int diaAtual = agora.Day;
            int mesAtual = agora.Month;
            int anoAtual = agora.Year;
            int diaNasc = dataNascimento.Day;
            int mesNasc = dataNascimento.Month;
            int anoNasc = dataNascimento.Year;

            int age = anoAtual - anoNasc;
            if (mesAtual < mesNasc || (mesAtual == mesNasc && diaAtual < diaNasc))
            {
                age--;
            }
            return age;

        }
    }
}
