using System;
using Revisando;


class Gato : Animal
{
  public Gato(string nome, string cor, int idade) : base (nome,cor,idade) { }

  public override void FazerSom()  
  {
    Console.WriteLine("Miau miau mia");
  }
}
