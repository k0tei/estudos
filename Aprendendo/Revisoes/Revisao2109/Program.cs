using System;
using System.Linq;

namespace Revisando
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Kotei is back
      // Controle de fluxo é quando um programa escolhe qual o camiho que ele vai seguir e quais blocos
      // de código que vão ser efetivamente executados, ele permite ignorar código que só poderia
      // ser executado em uma determinada condição
      //
      // Estrutura condicionais são estruturas de controle de fluxo, que permitem que o programa
      // tome decisões especificas conforme uma condição é atingida ou não. IF-ELSE, ELSE-IF, SWITCH
      //
      // Estruturas de repetição são estruturas que executam um determinado bloco de código repetidamente
      // conforme informado na estrutura. FOR, FOREACH, WHILE, DO WHILE.
       Cachorro cao = new Cachorro("zeus","marrom", 2);   
       Gato fofo = new Gato("pinkie", "branca", 1);
       Passaro titi = new Passaro("zulu", "verde", 3);
       Console.WriteLine(cao.Nome);
       Console.WriteLine(cao.Cor);
       Console.WriteLine(cao.Idade);  
       Console.WriteLine(fofo.Nome);  
       Console.WriteLine(fofo.Cor);  
       Console.WriteLine(fofo.Idade);  
       cao.FazerSom();
       fofo.FazerSom();
    }
  }
  abstract class Animal
  {
      protected string _nome;
      protected string _cor;
      protected int _idade;
      
      public string Nome
      {
        get { return _nome; }
        set
        {
          _nome = value;
        }
      }

      public string Cor
      {
        get{ return _cor; }
        set{ _cor = value; } 
      }

      public int Idade 
      {
        get{ return _idade; }
        set{ _idade = value; }
      }

      public Animal(string nome, string cor, int idade)
      {
        Nome = nome;
        Cor = cor;
        Idade = idade;
      }

      public abstract void FazerSom();
  }
}
