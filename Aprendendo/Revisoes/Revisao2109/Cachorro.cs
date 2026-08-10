using System;
using Revisando;


class Cachorro : Animal
{
  public Cachorro(string nome, string cor, int idade) : base (nome,cor,idade) { }

  public override void FazerSom()  
  {
    Console.WriteLine("Au au au au");
  }
}
