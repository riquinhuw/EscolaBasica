using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaBasica
{
    class Program
    {
        static void Main()
        {
            //vou fazer algo bem simples
            Curso.logo();
            Aluno estudante1 = new Aluno();
            estudante1.Nome = "Paulo";
            estudante1.Idade = 17;
            estudante1.Classe = "14-A";
            Professor professor1 = new Professor();
            professor1.Nome = "Raoni";
            professor1.Diciplica = "Programacao";
            professor1.Salario = 8001;
            professor1.Turma = "14-A";
            Coordenador coordenador1 = new Coordenador();
            coordenador1.Nome = "Romulo";
            coordenador1.Salario = 10001;
            coordenador1.Telefone = 9123123;
            Diciplina disciplina1 = new Diciplina();
            disciplina1.nome = "Programacao";
            disciplina1.Descricao = "Voce ira passar o restante da sua vida procurando bugs, porem nao ira conseguir resolvar a tempo e virara noites bebendo cafe para corrigir o bug";
            disciplina1.conceito = "Formar dependentes de cafeína compentes no seu trabalho escravo de multi nacionais";


            Aluno estudante2 = new Aluno();
            Console.Write("Digite o nome do aluno:");
            estudante2.Nome = Console.ReadLine();
            Console.Write("Digite a Idade do aluno:");
            estudante2.Idade = int.Parse(Console.ReadLine());
            if (estudante2.Idade < 18) { estudante2.MenorDeIdade = true; }else { estudante2.MenorDeIdade = false; }
            Console.Write("Digite a matricula do aluno:");
            estudante2.Matricula = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do responsavel pelo aluno:");
            estudante2.Responsavel = Console.ReadLine();
            Console.Write("Digite a classe do aluno:");
            estudante2.Classe = Console.ReadLine();
            Console.Write("Digite o CPF do aluno:");
            estudante2.Cpf = int.Parse(Console.ReadLine());
            Console.Write("Digite o Sexo do aluno(a)");
            estudante2.Sexo = Console.ReadLine();

            Console.Clear();
            Curso.logo2();

            Professor professor2 = new Professor();
            Console.Write("Digite o nome do professor a ser contratado:");
            professor2.Nome = Console.ReadLine();
            Console.Write("Digite do RG do professor:");
            professor2.Rg = int.Parse(Console.ReadLine());
            Console.Write("Digite o Salario do professor:");
            professor2.Salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da turma que o professor é responsavel:");
            professor2.Turma = Console.ReadLine();

            Console.Clear();
            Curso.logo3();

            Coordenador coordenador2 = new Coordenador();
            Console.Write("Digite o nome do coordenador:");
            coordenador2.Nome = Console.ReadLine();
            Console.Write("Digite do RG do coordenador:");
            coordenador2.Rg = int.Parse(Console.ReadLine());
            Console.Write("Digite o Salario do coordenador:");
            coordenador2.Salario = int.Parse(Console.ReadLine());

            Curso curso1 = new Curso("Ciencia da computacao");

            Console.Clear();
            Curso.logo4();

            Console.WriteLine("O aluno que foi criado foi:");
            Console.WriteLine("Seu nome e:{0}\nSua idade e:{1}\nEle e' menor de idade:{2}\nSua matricula e:{3}\nPertence a sala:{4}", estudante2.Nome, estudante2.Idade, estudante2.MenorDeIdade, estudante2.Matricula, estudante2.Classe);
            Console.WriteLine("O professor criado foi:");
            Console.WriteLine("Nome:{0}\nRG:{1}\nSalario:{2}", professor2.Nome, professor2.Rg, professor2.Salario);
            Console.WriteLine("O Coordenador criado foi:");
            Console.WriteLine("Nome:{0}\nRG:{1}\nSalario:{2}", coordenador2.Nome, coordenador2.Rg, coordenador2.Salario);
            Console.WriteLine("\nO curso escolhido foi {0}:",curso1.nome);
            Console.WriteLine("Cuja a descricao e:{0}\nO conceito e:{1}",disciplina1.descricao,disciplina1.conceito);
            Console.WriteLine("E a cadeira padrao e:{0}", disciplina1.nome);

        }
    }
}
