using System;

namespace Program
{
  class Programa
  {
    static void Main()
    {
      Jogador player1 = new Jogador("Samuel", 15, 40);

      player1.Atirar();
      player1.Andar();
      Jogador.GameOver();
    }
  }
  
  class Jogador
  {
    public int vida;
    public int vidaMaxima;
    public string nome;
    private static int totalDeJogadores;

    // Construtor
    public Jogador(string nome, int vida, int vidaMaxima)
    {
      this.vida = vida;
      this.vidaMaxima = vidaMaxima;
      this.nome = nome;
      totalDeJogadores++;
    }
    public void Atirar()
    {
      Console.WriteLine($"{nome}: Eu estou atirando");
    }
    public void Andar()
    {
      Console.WriteLine("Para onde você quer andar?");
      Console.WriteLine("1. Para cima");
      Console.WriteLine("2. Para baixo");
      Console.WriteLine("3. Para direita");
      Console.WriteLine("4. Para esquerda"); 
      int opcao = Convert.ToInt32(Console.ReadLine()!);
      switch(opcao)
      {
        case 1:
          Console.WriteLine("Você andou para cima");
          break;
        case 2:
          Console.WriteLine("Você andou para baixo");
          break;
        case 3:
          Console.WriteLine("Você andou para direta");
          break;
        case 4:
          Console.WriteLine("Você andou para baixo");
          break;
        default:
          Console.WriteLine("Opção inválida. Tente novamente");
          break;
      }
    }
    public static void GameOver() 
    {
        Console.WriteLine("O jogador morreu.");
        Console.WriteLine("Game Over");
    }
  }
}
