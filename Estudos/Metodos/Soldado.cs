namespace ExercicioDeFixacao
{
  class Soldado
  {
    private float _vida,_vidaMaxima, _velocidade, _velocidadeDeAtaque, _critico;
    private int _municao, _municaoTotal, _forca, _defesa, _nivel;

    public Soldado(float vida, float vidaMaxima, float velocidade,
                  float velocidadeDeAtaque, float ataque, int defesa, 
                  int nivel, int municao, int municaoTotal, int forca,int critico)
    {
      Vida = vida;
      _vidaMaxima = vidaMaxima;
      _velocidade = velocidade;
      _defesa = defesa;
      _nivel = nivel;
      _municaoTotal = municaoTotal;
      _municao = municao;
      _velocidadeDeAtaque = velocidadeDeAtaque;
      _critico = critico;
    }

    public float Vida 
    {
      get { return _vida; }
      set 
      {
        if(_vida < 0)
        {
          _vida = 0;
        }
        else if(_vida > _vidaMaxima)
        {
          _vida = _vidaMaxima;
        }
        else
        {
          _vida = value;
        }
      }
    }
    void Atirar()
    {
      if (_municao > 0)
      {
        Console.WriteLine("Soldado está atirando!");
        _municao -= 1;
      }
      else 
      {
        Console.WriteLine("A munição acabou!");
      }
    }
    void Rajada()
    {
      if (_municao > 0 && _municao > 10)
      {
        Console.WriteLine("O Soldado soltou uma rajada de tiros!!");
        _municao -= 10;
      }
      else
      {
        Console.WriteLine("Munição insuficiente para a rajada");
      }
    }
    void Defender()
    {
      Console.WriteLine("Soldado está se defendendo");
      _defesa += 5;
    }
    void AnalisarInimigo()
    {
      Console.WriteLine("As defesas do inimigo foram analisadas. Sua margem de dano critico aumentou");
      _critico += 2;
    }
    void Correr()
    {
      _velocidade += 5;
      Console.WriteLine($"O Soldado está correndo e percorreu {_velocidade} metros");
      _velocidade -= 5;

    }
    void Andar()
    {
      Console.WriteLine($"Soldado está andando {_velocidade} metros");
    }
  }
}
