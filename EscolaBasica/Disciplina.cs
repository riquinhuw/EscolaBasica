using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Diciplina
    {
        public Aluno aluno = new Aluno();
        public Professor professor = new Professor();
        public string nome;
        public string descricao;
        public string conceito;

        public Aluno Aluno { get => aluno; set => aluno = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Diciplina() { }
        

    }
}
