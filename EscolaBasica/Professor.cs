using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Professor : Pessoa
    {

        private double salario;
        private int id;
        private string turma;
        private int vagaDoCarro;
        private string diciplica; //seria da classe diciplica, mas não deu para desenvolver trabalhei pouco nesse trabalho

        public double Salario { get => salario; set => salario = value; }
        public int Id { get => id; set => id = value; }
        public string Turma { get => turma; set => turma = value; }
        public int VagaDoCarro { get => vagaDoCarro; set => vagaDoCarro = value; }
        public string Diciplica { get => diciplica; set => diciplica = value; }

        public Professor() { }
        public Professor(string nome, int idade, int cpf, string sexo,int id,string turma,double salario)
        {
            
            this.Id = id;
            this.Turma = turma;
            this.Salario = salario;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Idade = idade;
        }
        
    }
}
