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
        private Disciplina diciplica;


        public Professor() { }
        public Professor(string nome, int idade, int cpf, string sexo,int id,string turma,double salario)
        {
            
            this.id = id;
            this.turma = turma;
            this.salario = salario;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Idade = idade;
        }
        
    }
}
