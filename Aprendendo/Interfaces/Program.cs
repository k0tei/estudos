using System;

namespace Interfaces
{
  class Programa
  {
    static void Main()
    {
      Guerreiro guerreiro = new Guerreiro();
      guerreiro.Atacar();
      guerreiro.Habilidades();
      guerreiro.Espada();
    }
  }

  interface IClasses
  {
    public void Atacar();
    public void Habilidades(); 
  }
  interface IArmas 
  {
    public void Espada();
  }
  class Guerreiro() : IClasses, IArmas
  {
    public void Atacar()
    {
      Console.WriteLine("Estou atacando com a espada");
    }
    public void Habilidades()
    {
      Console.WriteLine("Estou usando uma habilidade de classe");
    }
    public void Espada()
    { 
      Console.WriteLine("Minha espada reluzente");
    }
  }
}



