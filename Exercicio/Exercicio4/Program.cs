using System;

namespace Exercicios
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Digite um número");
      int a = Conver.ToInt32(Console.ReadLine());
      Console.WriteLine("Digite outro número");
      int b = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("A soma dos dois números é:");
      Console.WriteLine(Soma(a,b));
    }
    static int Soma(int x, int y)
    {
      return x + y;
    }
  }
}
