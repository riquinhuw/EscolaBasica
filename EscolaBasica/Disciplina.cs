using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class @string
    {
        private Aluno aluno = new Aluno();
        private Professor professor = new Professor();
        private string nome;
        private string descricao;

        public Aluno Aluno { get => aluno; set => aluno = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        @string() { }
        

    }
}
