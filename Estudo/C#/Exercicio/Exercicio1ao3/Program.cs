using System;


namespace Exercicios
{
    class Program
    {
      static void Main()
      {
        Console.WriteLine("Boas vindas");
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é o seu salário?"); 
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Seja bem-vindo");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário: {salario}");

      }
    }
}
