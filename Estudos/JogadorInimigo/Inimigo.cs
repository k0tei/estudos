namespace Jogo
{
  class Inimigo
   {
      private float _vida, _velocidade,_direcao, _posicao, _forca;
      private string _nome;

      public Inimigo(string nome, float vida, float velocidade, float forca)
      {
        _nome = nome;
        _vida = vida;
        _velocidade = velocidade;
        _forca = forca;
      }


      public void Movimentacao(Jogador alvo)
      {
        // calcula a direcao com base na posicao do jogador, fiz desse jeito pro inimigo sempre seguir o alvo
        _direcao = alvo.Posicao - _posicao;
        _posicao += (_direcao * _velocidade);
      }
      public void Atacar(Jogador alvo)
      {
        alvo.Vida -= _forca;
        Console.WriteLine("Ataque realizado");
        Console.WriteLine($"O alvo perdeu {_forca} de vida");
        Console.WriteLine($"O alvo esta com {alvo.Vida}");
      }
   }
}
