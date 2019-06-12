using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePessoas
{
    class Pessoa
    {
        public String Nome { set; get; }
        public Int32 Idade { set; get; }
        public DateTime Nascimento { set; get; }
        public String Profissao { set; get; }
        public String Sexo { set; get; }
        public Int64 Telefone { set; get; }

        /*
        private String nome;
        public void setNome(String valor)
        {
            this.nome = valor;
        }

        public String getNome()
        {
            return this.nome;
        }

        private Int32 _idade;
        public Int32 Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
        */
    }
}
