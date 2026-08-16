using System;

namespace Heranca
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Tudo dentro dos conformes");
    }
  }

  class Personagem
  {
    string nome;
    decimal vida;
    decimal vidaTotal;
    decimal dano;
    void Atacar()
    {
      Console.WriteLine($"{nome} está atacando");
      Console.WriteLine($"O ataque causou {dano} de dano total");
    }
  }

  class Paladino : Personagem
  {
    int cura;
    void Curar()
    {
      Console.WriteLine($"{nome} está curando todos ao seu redor");
    }
  }

}
