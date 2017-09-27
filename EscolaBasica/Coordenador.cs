using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Coordenador : Pessoa
    {
        private double salario;
        private int vagaDoCarro;
        private int id;

        public Coordenador() { }
        public Coordenador(string nome, int idade, int cpf, string sexo, int id, double salario)
        {

            this.id = id;
            this.salario = salario;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Idade = idade;

        }

    }
}
