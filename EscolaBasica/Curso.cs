using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    public class Curso
    {
        private string nome;

        Curso() { }
        Curso(string nome) { this.Nome = nome; }

        public string Nome { get => nome; set => nome = value; }
    }
}
