using System;

namespace Estudos
{
  class Programa
  {
    static void Main()
    {
      Carro carro1 = new Carro(120);
      Bicicleta bike = new Bicicleta(40);
      carro1.Andar();
      bike.Andar();
    }
  }

  class Veiculo
  {
    private int _speed;

    public Veiculo(int velocidade)
    {
      Speed = velocidade;
    }
    public int Speed 
    {
      get
      {
        return _speed;
      }
      set
      {
        if (value > 150) 
        {
          _speed = 150;
        } 
        else if (value < 0) 
        {
          _speed = 0;
        } 
        else 
        {
          _speed = value;
        }
      }
    }
    public void Andar()
    {
      Console.WriteLine("Eu estou andando");
    }
  }

  class Carro : Veiculo
  {
    public Carro(int velocidade) : base (velocidade) {}
    
    public int portas = 4;
  }
  class Bicicleta : Veiculo
  {
    public Bicicleta(int velocidade) : base(velocidade) {}
    public int rodas = 2;
  }
}
