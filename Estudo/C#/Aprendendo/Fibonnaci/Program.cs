using System;

namespace FibonacciExercicio
{
    
  class Principal
  {
    static void Main()
    {
      Console.WriteLine(Fib(4));
    }

    public static int Fib(int n) 
    {
      int a = 1,b = 1,fibonacci = 0;
      if (n <= 2)
      {
        return n;
      }
      else
      {
        for(int i = 3; i <= n; i++)
        {
          fibonacci = a + b;
          a = b;
          b = fibonacci;
          
        }
        return fibonacci;
      }
    }
  }
}
