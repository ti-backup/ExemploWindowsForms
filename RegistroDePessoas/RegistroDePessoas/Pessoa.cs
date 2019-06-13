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
        public Int32 Idade { private set; get; }
        public String Profissao { set; get; }
        public String Sexo { set; get; }
        public Int64 Telefone { set; get; }

        private DateTime _nascimento;
        public DateTime Nascimento
        {
            set
            {
                _nascimento = value;
                Idade = CalculaIdade();
            }
            get { return _nascimento; }
        }

        private Int32 CalculaIdade()
        {
            DateTime hoje = DateTime.Now;
            Int32 resultado = hoje.Year - Nascimento.Year;

            if (
                Nascimento.Month > hoje.Month
                ||
                (Nascimento.Month == hoje.Month && Nascimento.Day > hoje.Day)
                )
            {
                resultado--;
            }
            
            return resultado;
        }


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
