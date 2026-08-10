using System;

namespace Aplicativo
{
  class Programa 
  {
    static void Main()
    {
      Produto produto1 = new Produto("Arroz",20,50);
    }
  }

  class Produto
  {
    private string nome;
    private double preco;
    private int quantidade;

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public double Preco
    {
      get { return preco; }

      set
      {
        if (value > 500)
        {
          preco = 500;
        }
        else
        {
          preco = value;
        }
      }
    }

    public int Quantidade
    {
      get { return quantidade; }
      set
      {
        if (quantidade < 0)
        {
          Console.WriteLine("A quantidade não pode ser negativa");
        }
        else
        {
          quantidade = value;
        }
      }
    }
    public Produto(string nome,double preco, int quantidade)
    {
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;

    }
  }
}

