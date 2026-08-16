using System;


namespace AprendendoPoo
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Meu programa principal");
      Cachorro.Latir();
      Pessoa.Falar(); 
    }
  }

  public static class Cachorro
  {
    public static void Latir()
    {
      Console.WriteLine("Au au au");  
    }
  }
}
