 using System;

 namespace RevisaoPOO
 {
   class Programa
   {
     static void Main()
     {
       Livro book = new Livro("JK", "Harry Potter", 100);
       Livro book2 = Copiar(book);

       Console.WriteLine(book.Titulo);
       MudarNome(book, "A pedra filosofal");
       

       static void MudarNome(Livro livro, string nome)
       {
         livro.Titulo = nome;
       }

       static Livro Copiar(Livro livro)
       {
          return new Livro(livro.Titulo, livro.Autor, livro.Quantidade);
       }

       Console.WriteLine(book.Titulo);
       Console.WriteLine(book2.Titulo);

      book.Emprestar(50);
     }
   } 
 }
