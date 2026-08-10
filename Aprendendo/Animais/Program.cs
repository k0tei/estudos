using System;

namespace Animas
{
  class Programa
  {
    static void Main()
    {
      Dog cao = new Dog("Toto", "Auau", 15);
      cao.Latir();
      Console.WriteLine(cao.Idade);
    }
  }

  class Animal
  {
    protected string _nome;
    protected string _som;
    protected int _idade;
    
    // Construtor
    public Animal (string nome, string som, int idade)
    {
      Nome = nome;
      Som = som;
      Idade = idade;
    }
    // Propriedades
    
    public string Nome
    {
      get { return _nome; }
      set { _nome = value; }
    }

    public string Som 
    {
      get{ return _som; }
      set
      {
        if(!string.IsNullOrEmpty(value))
        {
          _som = value;
        }
        else 
        {
          _som = "Este animal não produz som";
        }

      }
    }

    public int Idade 
    {
      get { return _idade; }
      set
      {
        if (value < 0)
        {
          _idade = 0;
        }
        else
        {
          _idade = value;
        }
      }
    }
    protected void EmitirSom()
    {
      Console.WriteLine(_som);
    }
  }
}
