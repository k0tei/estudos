using System;
using System.Collections.Generic;

namespace Listas
{
   class Programa
   {
      static void Main()
     {
      List<string> listaDeCompras = new List<string>();

      listaDeCompras.Add("batata");
      listaDeCompras.Add("pao");
      listaDeCompras.Add("carne");
      listaDeCompras.Add("queijo");
      listaDeCompras.Add("mortadela");
      listaDeCompras.Insert(0, "atum");


      foreach(string valores in listaDeCompras)
      {
        Console.WriteLine(valores);
      }

      Console.WriteLine(listaDeCompras.IndexOf("queijo"));
      Console.WriteLine(listaDeCompras.Capacity);
      Console.WriteLine(listaDeCompras.Contains("tv"));

     } 
   }
   class Animal
    {
      void FazerSom()
      {
        Console.WriteLine("O animal está fazendo som");
      }
    }
}
