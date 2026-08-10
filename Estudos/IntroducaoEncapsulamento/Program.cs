namespace Encapsulamento
{
  class Program
  {
    static void Main(string[] args)
    {
      Permissao controleDeAcesso = new Permissao(12);

      controleDeAcesso.VerificarPermissao();
    }
  }
  class Permissao
  {
    private int _idade;
    public Permissao(int idade)
    {
      _idade = idade;
    }
    private void ChecarPermissao()
    {
      if(_idade < 18)
      {
        Console.WriteLine("Permissão negada!");
      }
      else
      {
        Console.WriteLine("Permissão concedida!");
      }
    }
    public void VerificarPermissao()
    {
      ChecarPermissao();
    }
  }
}
