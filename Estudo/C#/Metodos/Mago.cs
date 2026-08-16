namespace ExercicioDeFixacao
{
  class Mago
  {
    private float _vida;
    private float _vidaMaxima;
    private float _velocidade;
    private float _velocidadeDeAtaque;
    private float _ataque;
    private float _defesa;
    private float _mana;
    private int _nivel;
    private int _inteligencia;
    private string _resistenciaMagica = "Fogo";


    public Mago(float vida, float vidaMaxima, float velocidade, float velocidadeDeAtaque, float ataque,
                float defesa, float mana, int nivel, int inteligencia)
    {
      Vida = vida;
      _vidaMaxima = vidaMaxima;
      _velocidade = velocidade;
      _velocidadeDeAtaque = velocidadeDeAtaque;
      _ataque = ataque;
      _defesa = defesa;
      _mana = mana;
      _nivel = nivel;
      _inteligencia = inteligencia; 
    }
    public float Vida
    {
      get { return _vida; }
      set
      {
        if(_vida <= 0)
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


    public void Andar()
    {
      Console.WriteLine($"Estou andando {_velocidade} metros");
    }
    public void EscudoArcano()
    {
      _defesa *= 2;
      Console.WriteLine("Uma aura recobre você e dobra a sua defesa");
    }
    public void InvocarFamiliar()
    {
      Console.WriteLine("Você invocou um morcego!");
    }
    public void Ritual()
    {
      if (_inteligencia > 10)
      {
        Console.WriteLine("O ritual foi um sucesso!");
      }
      else
      {
        Console.WriteLine("O ritual foi um fracasso e você foi amaldiçoado!");
      }
    }
    public void BolaDeFogo()
    {
      Console.WriteLine("Bola de fogo!");
    }
    public void MagiaDeCura(float cura)
    {
      Console.WriteLine("Curando vida");
      Vida += cura;
    }
  }
}
