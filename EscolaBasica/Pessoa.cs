using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Pessoa
    {
        #region Atributos
        private string nome;
        private int idade;
        private int cpf;
        private int rg;
        private int telefone;
        private string sexo;
        private string endreco;
        private string bairro;
        private string cidade;
        private string complemento;
        private bool menorDeIdade;
        private string responsavel;
        #endregion

        #region GET SET
        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int Rg { get => rg; set => rg = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Endreco { get => endreco; set => endreco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public bool MenorDeIdade { get => menorDeIdade; set => menorDeIdade = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public int Idade { get => idade ; set => idade = value; }
        #endregion

        #region Metodos

        protected Pessoa(string nome,int idade,int cpf,string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.sexo = sexo;
            this.idade = idade;
            //if (idade < 18) { this.menorDeIdade = true; } else{ this.menorDeIdade = false; }
            
        }

        protected Pessoa() { }

        #endregion


    }
}
