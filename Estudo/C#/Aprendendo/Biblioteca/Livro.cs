using System;

namespace RevisaoPOO
{
  class Livro
  {
    protected string autor;
    protected string titulo;
    protected int quantidade;

    // Eu decidi colocar propriedades, construtores e metodos na respectiva ordem pq achei que seria mais legivel

    public string Autor
    {
      get { return titulo;}
      set { titulo = value; }
    }
    public string Titulo
    {
      get { return titulo; }
      set { titulo = value; }
    }
    public int Quantidade
    {
      get { return quantidade; }
      set
      {
        if (value <= 0)
        {
          Console.WriteLine("Erro, quantidade dos livros não pode ser menor ou igual a 0");
        }
        else 
        {
          quantidade += value;
        }
      }
    }

    public Livro(string autor, string titulo, int quantidade)
    {
      Autor = autor;
      Titulo = titulo;
      Quantidade = quantidade;
    }
    public void Emprestar(int quantidadeEmprestados)
    {
      if(!Disponibilidade(quantidadeEmprestados))
      {
       Console.WriteLine("Houve um erro, produto indisponivel");
      }
      else
      {
        quantidade -= quantidadeEmprestados;
        Console.WriteLine($"Emprestimo realizado. Retirado {quantidadeEmprestados} livros.");
      }
    }

    public void Devolver(int quantidadeDevolvida)
    {
      quantidade += quantidadeDevolvida;
    }
    
    // Melhorias nas estruturas logicas
    public bool Disponibilidade(int quantidadeEmprestados)
    {
      return quantidade > 0 && quantidadeEmprestados <= quantidade;
    }
  }
}
