using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Aluno : Pessoa
    {

        private int carteiraDeEstudante;
        private int matricula;
        private string classe;
        private bool bolsista;

        public int CarteiraDeEstudante { get => carteiraDeEstudante; set => carteiraDeEstudante = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public string Classe { get => classe; set => classe = value; }
        public bool Bolsista { get => bolsista; set => bolsista = value; }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }
        public Aluno() { }

        
        
        

    }
}
