namespace Jogo
{
  class Jogador
  {
    private float _vida, _velocidade, _direcao, _posicao;
    private string _nome;

    public Jogador(string nome, float vida, float velocidade)
    {
      _nome = nome;
      _vida = vida;
      _velocidade = velocidade;
    }
    public float Posicao
    {
      get
      {
        return _posicao;
      }
      private set{ }
    }
    public float Vida
    {
      get 
      {
        return _vida;
      }
      set
      {
        if(_vida <= 0)
        {
          _vida = 0;
        }
        else if(value > 100)
        {
          _vida = 100;
        }
        else 
        {
          _vida = value;
        }
      }
    }
    public void Atacar()
    {
      Console.WriteLine("");
      Console.WriteLine("Ataque realizado");
    }
    public void Movimentacao()
    {
      _direcao = getInput();

      _posicao = (_direcao * _velocidade);

      Console.WriteLine($"A posição atual do {_nome} é: {_posicao}");
    }
    int getInput()
    {
      ConsoleKeyInfo input = Console.ReadKey(true);
      switch(input.Key)
      {
        case ConsoleKey.A:
          return -1;
        case ConsoleKey.D:
          return 1;
        case ConsoleKey.Spacebar:
          Atacar();
          return 0;
        default:
          return 0;
      }
    }
  }
}
