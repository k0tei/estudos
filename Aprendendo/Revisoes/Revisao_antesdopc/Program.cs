using System;

namespace Programa
{
  class Principal
  {
    static void Main()
    {
      Guitarra pobre = new Guitarra(6);
      pobre.TocarMusica();
      Console.WriteLine(pobre.Cordas);
    }
  }

  class Instrumento
  {
    private int _cordas;

    public Instrumento(int cordas)
    {
      Cordas = cordas;
    }
    public int Cordas
    {
      get { return _cordas; }
      set { _cordas = value; }
    }
    public virtual void TocarMusica()
    {
      Console.WriteLine("O instrumento está tocando");
    }
  }
  
  class Guitarra : Instrumento
  {
    public Guitarra(int cordas) : base(cordas){}

    public override void TocarMusica()
    {
      Console.WriteLine("É ROCK PORRA");
      Console.WriteLine("Pewheinewiewn");
    }
  }
}

