using System;

namespace Projeto
{
  class Teste
  {
    static void Main()
    {
      int age = 17;
      string name = "Samuel";
      
      Console.WriteLine(name + " tem " + age + " anos");
      Console.WriteLine($"{name} tem {age} anos");
      Console.WriteLine("Teste \nde projeto");
      Console.WriteLine("Teste \tde projeto");
      Console.WriteLine("Nós somos os \"Vikings\" do norte!");
      Console.WriteLine("Mostrando o diretório:   Users\\");
      Console.WriteLine(@"Mostrando o diretório:  Users\\");
      Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Hello world em japônes
      Console.WriteLine("Eu sou o \"batman\"");
      Console.WriteLine(@"diretório 
      C:\Users\Usuario\Documents\Meus Projetos");
      short number1 = 12;
      short number2 = 7;
      Console.WriteLine(number1 + number2);
      Console.WriteLine(number2 + " tem "+ number1 + 5 + " casas"); // Exemplo errado
      Console.WriteLine(number2 + " tem "+ (number1+ 5) + " casas"); // Exemplo correto
      int first = 10;
      int second = 2;
      decimal quotient = (decimal)first/(decimal)second;
      Console.WriteLine(quotient);
    }
  }
}
