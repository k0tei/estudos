using System;

namespace Teste
{
  class Programa
  {
    static void Main()
    {
      Carro sidan = new Carro("azul","sidan");
      sidan.Acelerar();
    }
  }
  class Carro
  {
    protected string cor, modelo;
    public Carro(string cor, string modelo)
    {
      this.cor = cor;
      this.modelo = modelo;
    }
    public void Acelerar ()
    {
      Console.WriteLine($"O {this.modelo} está acelerando");
    }
  }
}
