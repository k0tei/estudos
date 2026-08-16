using System;

namespace Revisao
{
  class Program
  {
    enum Dias
    {
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
        Domingo
    }
    static void Main()
    {
      // Não quero me tornar um programador que só sabe copiar codigo

      Dias diaAtual = Dias.Domingo;
      Console.WriteLine(diaAtual);
      switch (diaAtual)
      {
        case Dias.Segunda:
          Console.WriteLine("Primeiro dia da semana");
          break;
        case Dias.Terça:
          Console.WriteLine("Segundo dia da semana");
          break;
        case Dias.Quarta:
          Console.WriteLine("Terça dia da semana");
          break;
        case Dias.Quinta:
          Console.WriteLine("Quinto dia da semana");
          break;
        case Dias.Sexta:
          Console.WriteLine("Sextouuuuuuuuuu");
          break;
        case Dias.Sabado:
          Console.WriteLine("Fim de semana");
          break;
        case Dias.Domingo:
          Console.WriteLine("RPG");
          break;
      }

    }
  }
  class Teste
  {

  }
}
