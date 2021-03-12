using System;

namespace nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("olá");
           Console.WriteLine("digite seu nome:");
           string nome = Console.ReadLine();
           Console.WriteLine();
           Console.WriteLine("seu sobrenome");
           string sobrenome = Console.ReadLine();
           Console.WriteLine();
           Console.Write("bem-vindo, ");
           Console.Write(nome );
           Console.Write(" ");
           Console.Write(sobrenome);
           Console.WriteLine();
           Console.WriteLine($"{sobrenome.ToUpper()}, {nome.ToLower()}");

        }
    }
}
