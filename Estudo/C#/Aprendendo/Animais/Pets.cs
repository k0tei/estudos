using System;

namespace Animas
{
  class Dog : Animal
  { 
    public Dog(string nome, string som, int idade) : base(nome,som,idade)     
    {
    }

    public void Latir()
    {
      EmitirSom();  
    }
  }
}
