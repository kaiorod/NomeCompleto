using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            
            string nome, sbnome;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Olá usuário, irei apresentar seu nome completo em Formato Padrão e Formato de Catálogo");
            Console.ResetColor();
            Console.WriteLine("Pressione enter para continuar . . .\n");
            Console.ReadKey();

            Console.Beep();
            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome : ");
            sbnome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nNome completo : {nome} {sbnome}");
            Console.WriteLine($"Nome de catálogo : {sbnome}, {nome}");
            Console.ResetColor();


        }
    }
}
