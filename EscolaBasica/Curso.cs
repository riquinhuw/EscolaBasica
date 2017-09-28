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

        public static void logo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@" .____                      .        _             _                  _                            ,__        ");Console.Write("\n");
            Console.Write(@" /       ___    ___  ,   .  |     ___/   ___    ___/   ___         ___/   __.          ___    ___  /  `   ___ "); Console.Write("\n");
            Console.Write(@" |__.   /   ` .'   ` |   |  |    /   |  /   `  /   | .'   `       /   | .'   \       .'   `  /   ` |__  .'   `"); Console.Write("\n");
            Console.Write(@" |     |    | |      |   |  |   ,'   | |    | ,'   | |----'      ,'   | |    |       |      |    | |    |----'"); Console.Write("\n");
            Console.Write(@" /     `.__/|  `._.' `._/| /\__ `___,' `.__/| `___,' `.___,      `___,'  `._.'        `._.' `.__/| |    `.___,"); Console.Write("\n");
            Console.Write(@"                                     `             `                  `                            /          "); Console.Write("\n");
            Console.Write("\n"); Console.Write("\n");
            Console.ResetColor();

        }
        public static void logo2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@" .____                      .        _             _                  _                            ,__        "); Console.Write("\n");
            Console.Write(@" /       ___    ___  ,   .  |     ___/   ___    ___/   ___         ___/   __.          ___    ___  /  `   ___ "); Console.Write("\n");
            Console.Write(@" |__.   /   ` .'   ` |   |  |    /   |  /   `  /   | .'   `       /   | .'   \       .'   `  /   ` |__  .'   `"); Console.Write("\n");
            Console.Write(@" |     |    | |      |   |  |   ,'   | |    | ,'   | |----'      ,'   | |    |       |      |    | |    |----'"); Console.Write("\n");
            Console.Write(@" /     `.__/|  `._.' `._/| /\__ `___,' `.__/| `___,' `.___,      `___,'  `._.'        `._.' `.__/| |    `.___,"); Console.Write("\n");
            Console.Write(@"                                     `             `                  `                            /          "); Console.Write("\n");
            Console.Write("\n"); Console.Write("\n");
            Console.ResetColor();

        }
        public static void logo3()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@" .____                      .        _             _                  _                            ,__        "); Console.Write("\n");
            Console.Write(@" /       ___    ___  ,   .  |     ___/   ___    ___/   ___         ___/   __.          ___    ___  /  `   ___ "); Console.Write("\n");
            Console.Write(@" |__.   /   ` .'   ` |   |  |    /   |  /   `  /   | .'   `       /   | .'   \       .'   `  /   ` |__  .'   `"); Console.Write("\n");
            Console.Write(@" |     |    | |      |   |  |   ,'   | |    | ,'   | |----'      ,'   | |    |       |      |    | |    |----'"); Console.Write("\n");
            Console.Write(@" /     `.__/|  `._.' `._/| /\__ `___,' `.__/| `___,' `.___,      `___,'  `._.'        `._.' `.__/| |    `.___,"); Console.Write("\n");
            Console.Write(@"                                     `             `                  `                            /          "); Console.Write("\n");
            Console.Write("\n"); Console.Write("\n");
            Console.ResetColor();

        }
        public static void logo4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@" .____                      .        _             _                  _                            ,__        "); Console.Write("\n");
            Console.Write(@" /       ___    ___  ,   .  |     ___/   ___    ___/   ___         ___/   __.          ___    ___  /  `   ___ "); Console.Write("\n");
            Console.Write(@" |__.   /   ` .'   ` |   |  |    /   |  /   `  /   | .'   `       /   | .'   \       .'   `  /   ` |__  .'   `"); Console.Write("\n");
            Console.Write(@" |     |    | |      |   |  |   ,'   | |    | ,'   | |----'      ,'   | |    |       |      |    | |    |----'"); Console.Write("\n");
            Console.Write(@" /     `.__/|  `._.' `._/| /\__ `___,' `.__/| `___,' `.___,      `___,'  `._.'        `._.' `.__/| |    `.___,"); Console.Write("\n");
            Console.Write(@"                                     `             `                  `                            /          "); Console.Write("\n");
            Console.Write("\n"); Console.Write("\n");
            Console.ResetColor();

        }
    }
}
