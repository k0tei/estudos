using System;
using Banco;

class Conta
{
  private string _nome;
  private double _saldo;
  
  public Conta(string nome, double saldo)
  {
    Nome = nome;
    Saldo = saldo;
  }

  public string Nome 
  {
    get { return _nome; } 
    set 
    {
      if (value.Length() > 26 || value.Length() < 0)
      {
        throw new InvalidNameLength("Tamanho do nome é invalido.");
      }
    }
  }
}
