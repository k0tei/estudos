using System;


namespace Jogo
{
  class Programa
  {
    static void Main()
    {
      Jogador player1 = new Jogador();

      player1.Dano(50);

      Console.WriteLine(player1.Vida);
      player1.Vida -= 20000;
      Console.WriteLine(player1.Vida);
    }
  }
  class Jogador
  {
    private static decimal vidaMaxima = 100;
    private decimal vida = vidaMaxima;
    
    public decimal Vida
    {
      get
      {
        return vida;
      }
      set 
      {
        if (value <= 0)
        {
          vida = 0;
        }
        else if (value > vidaMaxima)
        {
          vida = vidaMaxima;
        }
        else
        {
          vida = value;
        }
      }
    }
    public void Dano(decimal dano)
    {
      Vida -= dano;
    }

  }
}
