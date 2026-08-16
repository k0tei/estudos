using System;

namespace Jogo
{
  class Programa
  {
    static void Main()
    {
      Monstro papaiNoel = new Monstro("Santa", 350.5, 200.2, 350.5);

      papaiNoel.Atacar();
      Console.WriteLine(papaiNoel.Vida);
    }
  }

  class Personagem
  {
    protected string _nome;
    protected double _vidaMaxima;
    protected double _vida;
    protected double _forca;

    public Personagem(string nome, double vida, double forca, double vidaMaxima)
    {
      Nome = nome;
      VidaMaxima = vidaMaxima;
      Vida = vida;
      Forca = forca;
    }

    public string Nome 
    {
      get { return _nome; }
      set { _nome = value; }
    } 

    public double VidaMaxima
    {
      get { return _vidaMaxima; }
      set
      {
        if (_vidaMaxima < _vida)
        {
          _vidaMaxima = _vida;
        }
        else
        {
            _vidaMaxima = value;
        }
      }
    }

    public double Vida
    {
      get  { return _vida; }
      set
      {
        if (value > _vidaMaxima)
        {
           _vida = _vidaMaxima;
        }
        else if (value < 0)
        {
          _vida = 0;
        }
        else
        {
            _vida = value;
        }
      }
    }
    public double Forca
    {
      get { return _forca; }
      set { _forca = value; }
    }

    public void TomaDano(int dano)
    {
      Vida -= dano;
    }
  }

  class Monstro : Personagem
  {
    public Monstro(string nome, double vida, double forca, double vidaMaxima) 
            : base(nome, vida, forca, vidaMaxima) {}

    public void Atacar()
    {
      Console.WriteLine("AAAAAAAAAAAAAAAAAAAAA");
    }
  }
}
