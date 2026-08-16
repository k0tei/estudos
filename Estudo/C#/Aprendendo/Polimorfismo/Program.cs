using System;

namespace Polimorfismo
{
  class Programa
  {
    static void Main()
    {
      Gato felino = new Gato(4);
      Cachorro cao = new Cachorro();

      cao.FazerSom();
      felino.FazerSom();

      Console.WriteLine(felino.Patas);
    }
  }          
  class Animal
  {
   public virtual void FazerSom()
   {
     Console.WriteLine("fhaeflhaasjfkl");
   }
  } 

  class Gato : Animal
  {
   // Atributos 
   private int _patas;
   // Propriedades
   public int Patas
   {
     get { return _patas; }
     set {_patas = value; }
   }
   // Construtor
   public Gato (int patas)
   {
      Patas = patas;
   }
   // Polimorfismo
   public override void FazerSom()
   {
     Console.WriteLine("Miau");
   }
  }

  class Cachorro : Animal
  {
    public override void FazerSom()
    {
      Console.WriteLine("Au au");
    }
  }
}
