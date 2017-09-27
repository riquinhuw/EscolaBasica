using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            Professor p1 = new Professor();
            p1.Nome = "paulo";
            Console.WriteLine(p1.Nome);


        }
    }
}
