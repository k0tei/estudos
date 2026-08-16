using System;

namespace Construtor
{
  class Programa
  {
    static void Main()
    {
      Livro harryPotter = new Livro("Harry Potter", "JK", 2001);
      Livro semLancamento = new ("Morte do autor", "eu mesmo");
      Livro anonimo = new Livro("Hackerman");
    }
  }

  class Livro
  {
    string titulo;
    string autor;
    int lancamento;

    public Livro(string titulo)
    {
      this.titulo = titulo;
    }
    public Livro(string titulo, string autor)
    {
      this.titulo = titulo;
      this.autor = autor;
    }
    public Livro(string titulo, string autor, int lancamento)
    {
      this.titulo = titulo;
      this.autor = autor;
      this.lancamento = lancamento;
    }
  }
}
