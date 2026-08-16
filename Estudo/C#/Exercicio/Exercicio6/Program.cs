using System;

namespace Exercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      AntesOuDepois(10);
    }
    static void AntesOuDepois(int numero)
    {
      System.Console.WriteLine($"Antecessor: {numero-1}");
      System.Console.WriteLine($"Sucessor: {numero+1}");
    }
  }
}
