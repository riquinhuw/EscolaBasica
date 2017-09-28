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

            Aluno a1 = new Aluno();
            a1.Nome = "Paulo";
            a1.Idade = 17;
            a1.Classe = "14-A";
            Professor p1 = new Professor();
            p1.Nome = "Raoni";
            p1.Diciplica = "Programacao";
            p1.Salario = 8001;
            p1.Turma = "14-A";
            Coordenador c1 = new Coordenador();
            c1.Nome = "Romulo";
            c1.Salario = 10001;
            c1.Telefone = 9123123;
            Diciplina d1 = new Diciplina();
            d1.nome = "Programacao";
            d1.Descricao = "TU VAI PASSARA VIDA TODA DIIGITANDO NA FRENTE DO PC E FICANDO GORDO, SEU DEPENDENTE DE CAFE!!!";
            d1.conceito = "Formar dependentes de cafeína compentes no seu trabalho escravo de multi nacionais";
            Aluno a2 = new Aluno();


            Console.WriteLine("Faculdade Dos Geras - Programa simplificado\n");
            Console.Write("Digite o nome do aluno:");
            a2.Nome = Console.ReadLine();
            Console.Write("Digite a Idade do aluno:");
            a2.Idade = int.Parse(Console.ReadLine());
            if (a2.Idade < 18) { a2.MenorDeIdade = true; }else { a2.MenorDeIdade = false; }
            Console.Write("Digite a matricula do aluno:");
            a2.Matricula = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do responsavel pelo aluno:");
            a2.Responsavel = Console.ReadLine();
            Console.Write("Digite a classe do aluno:");
            a2.Classe = Console.ReadLine();
            Console.Write("Digite o CPF do aluno:");
            a2.Cpf = int.Parse(Console.ReadLine());
            Console.Write("Digite o Sexo do aluno(a)");
            a2.Sexo = Console.ReadLine();

            Console.Clear();

            Professor p2 = new Professor();
            Console.Write("Digite o nome do professor a ser contratado:");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite do RG do professor:");
            p2.Rg = int.Parse(Console.ReadLine());
            Console.Write("Digite o Salario do professor:");
            p2.Salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da turma que o professor é responsavel:");
            p2.Turma = Console.ReadLine();

            Console.Clear();
            Coordenador c2 = new Coordenador();
            Console.Write("Digite o nome do coordenador:");
            c2.Nome = Console.ReadLine();
            Console.Write("Digite do RG do coordenador:");
            c2.Rg = int.Parse(Console.ReadLine());
            Console.Write("Digite o Salario do coordenador:");
            c2.Salario = int.Parse(Console.ReadLine());

            Curso curso1 = new Curso("Ciencia da computacao");
            

            Console.Clear();

            Console.WriteLine("O aluno que foi criado foi:");
            Console.WriteLine("Seu nome e:{0}\nSua idade e:{1}\nEle e' menor de idade:{2}\nSua matricula e:{3}\nPertence a sala:{4}", a2.Nome, a2.Idade, a2.MenorDeIdade, a2.Matricula, a2.Classe);
            Console.WriteLine("O professor criado foi:");
            Console.WriteLine("Nome:{0}\nRG:{1}\nSalario:{2}", p2.Nome, p2.Rg, p2.Salario);
            Console.WriteLine("O Coordenador criado foi:");
            Console.WriteLine("Nome:{0}\nRG:{1}\nSalario:{2}", c2.Nome, c2.Rg, c2.Salario);
            Console.WriteLine("\nO curso escolhido foi {0}:",curso1.nome);
            Console.WriteLine("Cuja a descricao e:{0}\nO conceito e:{1}",d1.descricao,d1.conceito);
            Console.WriteLine("E a cadeira padrao e:{0}", d1.nome);

        }
    }
}
