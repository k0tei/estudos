using System;


namespace Array
{
  class Programa
  {
    static void Main()
    {
      
      ContadorVetor();
      ContadorForEach();
      ContadorMatriz();

    }

    static void ContadorVetor()
    {
      int[] vetor = new int[4] {1,2,3,4};

      for (int i = 0; i < vetor.Length; i++)
      {
        Console.WriteLine(vetor[i]);
      }
    }

    static void ContadorForEach()
    {
      int[] vetor2;
      vetor2 = new int[4] {1,2,3,4};
      
      foreach(int numeros in vetor2)
      {
        Console.Write(numeros);
      }
      Console.WriteLine("");
    }

    static void ContadorMatriz()
    {
      int[,] matriz = new int[2,2] {{3, 6}, {2,5}};

      for(int i = 0; i < matriz.GetLength(0); i++)
      {
        for(int j = 0;j < matriz.GetLength(1);j++)
        {
          Console.WriteLine(matriz[i,j]);
        }
      }
    }
  }
}
