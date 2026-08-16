using System;

namespace Estudos
{
  class Programa
  {
    static void Main()
    {
      double[] hits = {25,21,33,99,44,22};
      Console.WriteLine(Dano(5.5,20.9,40.2));
      Console.WriteLine(Dano(5.5,20.9,40.2,80.3,400));
      Console.WriteLine(Dano(15.5,14.3,12.2,33.1));
      Console.WriteLine(Dano(hits));
    }

    static double Dano(params double[] danos)
    {
      double danoTotal = 0;
      foreach (double dano in danos)
      {
        danoTotal += dano;
      }
      return danoTotal;
    }
  }
}
