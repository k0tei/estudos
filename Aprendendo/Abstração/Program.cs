using System;

namespace Abstrato
{
  public class Programa
  {
    static void Main()
    {
      Gato preto = new Gato();
      Cachorro toto = new Cachorro();

      preto.Som();
      preto.Dormir();
      toto.Som();
      toto.Dormir();
    }
  }
  abstract class Animal
  {
    private int _patas;

    public int Patas
    {
      get { return _patas; }
      set 
      {
        if (value <= 0)
        {
          _patas = 1;
        }
        else if (value > 1306)
        {
          _patas = 1306;       
        }
        else
        {
          _patas = value;
        }
      }
    }

    public void Dormir()
    {
      Console.WriteLine("zZzZzZzZzZz");
    }
    
    public abstract void Som();
  }
  class Gato : Animal
  {
    public Gato()
    {
      Patas = 4;
    }
    
    public override void Som()
    {
      Console.WriteLine("Miau miau miau");
    }
  }
  class Cachorro : Animal
  {
    
    public Cachorro()
    {
      Patas = 4;
    }
    
    public override void Som()
    {
      Console.WriteLine("Au au au");
    }
  }

}
