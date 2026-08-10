using System;
using Revisando;


class Passaro : Animal
{
  public Passaro(string nome, string cor, int idade) : base (nome,cor,idade) { }

  public override void FazerSom()  
  {
    Console.WriteLine("craa craa");
  }
}
