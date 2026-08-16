using System; 

namespace TestandoProjetos
{
	class Teste 
	{
		static void Main()
		{
      Casamento();
			GeradorCoracao(20);
			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("Eu amo a *******");
			}
		}
    
		static void GeradorCoracao(int quantidade)
		{

			if (quantidade <= 0)
			{
				return;
			}
			do
		  {
				Console.WriteLine("S2");
				quantidade--;
			}while(quantidade > 0);
		} 
    
    static void Casamento()
    {
      Console.WriteLine("Você quer casar comigo?");
      string resposta = Console.ReadLine();
      resposta = resposta.ToLower();
      if (resposta == "sim"|| resposta == "s")
      {
        Console.WriteLine("Estamos casados!!!");
      }
      else
      {
          Console.WriteLine("Você não tem opção");
      }
    }
	}
}
