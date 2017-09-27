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

        public double Salario { get => salario; set => salario = value; }
        public int VagaDoCarro { get => vagaDoCarro; set => vagaDoCarro = value; }
        public int Id { get => id; set => id = value; }

        public Coordenador() { }
        public Coordenador(string nome, int idade, int cpf, string sexo, int id, double salario)
        {

            this.Id = id;
            this.Salario = salario;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Idade = idade;

        }

    }
}
