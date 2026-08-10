using System;


namespace Exercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite sua primeira nota");
      double nota1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite sua segunda nota");
      double nota2 = Convert.ToDouble(Console.ReadLine());
      double media = Media(nota1,nota2);

      Console.WriteLine($"Sua media final é {media}");
    }
    static double Media(double x, double y)
    {
      return (x + y)/2;
    }
  }
}
