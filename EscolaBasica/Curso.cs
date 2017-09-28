using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Curso
    {
        public string nome;

        public Curso() { }
        public Curso(string nome) { this.Nome = nome; }

        public string Nome { get => nome; set => nome = value; }
    }
}
