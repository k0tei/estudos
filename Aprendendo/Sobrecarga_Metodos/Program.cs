using System;


namespace Sobrecarga
{
  class Metodos()
  {
    static void Main()
    {
     int a = Somar(5,5);
     double b = Somar(2.5,2.5);
     int c = Somar(2,2,2);
      
      Console.WriteLine($"{a}\n{b}\n{c}");
    }

    public static int Somar(int x, int y)
    {
      return x + y;
    }

    public static double Somar(double x, double y)
    {
      return x + y;
    }
    
    public static int Somar(int x, int y, int z)
    {
      return x + y + z;
    }

  }
}

