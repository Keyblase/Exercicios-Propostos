using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAmigo
{
    public class Amigo : Pessoa
    {
        private string apelido;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;

        public int Id { get; set; }//private
        public String Apelido { get => apelido; set => apelido = value; }
        public String Endereco { get => endereco; set => endereco = value; }
        public String Bairro { get => bairro; set => bairro = value; }
        public String Cep { get => cep; set => cep = value; }
        public String Uf { get => uf; set => uf = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public Amigo() : base()
        {

        }

        public Amigo(string apelido)
        {
            this.apelido = apelido;
        }

        public Amigo(string apelido, string endereco, string bairro, string cep, string cidade)
        {
            this.apelido = apelido;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
        }

        public  Amigo(int id, string nome, DateTime dataNascimento, char sexo, string telefone, string apelido, 
            string endereco, string bairro, string cep, string cidade, string uf) : base(id,nome,dataNascimento,sexo,telefone)
        {
            this.apelido = apelido;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
        }

     
    }
}
