namespace Jogo
{
  class Program
  {
    static void Main(string[] args)
    {
        Jogador jogador1 = new Jogador("Douglas", 10f, 1.5f);
        Jogador jogador2 = new Jogador("Matias", 5f, 3.5f);
        Jogador jogador3 = new Jogador("Maicon", 20f, 0.5f);

        Inimigo inimigo1 = new Inimigo("Zosuaie", 5f, 7.2f, 3.5f);
        Inimigo inimigo2 = new Inimigo("Inimigae", 8f, 0.6f, 7f);
        Inimigo inimigo3 = new Inimigo("Fortao", 12f, 0.3f, 15f);

        jogador1.Movimentacao();
        jogador2.Movimentacao();
        jogador3.Movimentacao();

        inimigo1.Movimentacao(jogador1);
        inimigo2.Movimentacao(jogador2);
        inimigo3.Movimentacao(jogador3);

        inimigo1.Atacar(jogador1);
        inimigo2.Atacar(jogador2);
        inimigo3.Atacar(jogador3);
    }
  }
}


