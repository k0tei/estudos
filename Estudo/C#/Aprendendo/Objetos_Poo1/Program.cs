using System;

namespace Objetos
{
  class Program
  {
    static void Main()
    {
      Humano eu = new Humano("Samuel", 17, 60);
      Humano ela = new Humano("Valentina", 16, 45);

      ela.Dormir();

      eu.Falar();
      eu.Dormir();
    }
  }

  class Humano
  {
    public string nome;
    public int idade;
    public double peso;

    // Construtor
    public Humano(string nome, int idade, double peso)
    {
      this.nome = nome;
      this.idade = idade;
      this.peso = peso;
    }
    public void Falar()
    {
      Console.WriteLine($"{nome}: Eu sou humano. Mas o que é ser um humano?");
    }

    public void Dormir()
    {
      Console.WriteLine($"{nome} Está dormindo. Você não pode falar com ele agora");
    }
  }
}
