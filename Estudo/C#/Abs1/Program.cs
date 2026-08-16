using System;
// Feito por Samuel Henrique Alves de Souza e Valentina Moraes Binding
// Optamos por não usar herança ja que o exercicio pedia apenas abstração
// E entendemos que isso significa que deveriamos fazer tudo a mão, 
// e fizemos então desse jeito mas mantendo as boas praticas da programação
namespace Veiculos
{
  class Program
  { 
    static void Main(string[] args)
    {
      // Instancias das Motos
      Moto moto1 = new Moto("Yamaha", "MT-07", "Preta", "Combustão", 
                            200, 4.0f);
      Moto moto2 = new Moto("Honda", "CB 500F", "Vermelha", "Combustão", 
                            180,3.5f);
      Moto moto3 = new Moto("Suzuki", "GSX-S750", "Azul", "Combustão",
                            210, 4.5f);
      Moto moto4 = new Moto("Kawasaki", "Ninja 400", "Verde", "Combustão",
                            190, 4.0f);
      Moto moto5 = new Moto("BMW", "G 310 R", "Branca", "Combustão", 
                            170, 3.0f);

      // Instancias dos carros
      Carro carro1 = new Carro("Toyota", "Corolla", "Branco", "Híbrido", 
                              180, 7.0f);
      Carro carro2 = new Carro("Honda", "Civic", "Prata", "Gasolina", 
                               190, 7.5f);
      Carro carro3 = new Carro("Ford", "Mustang", "Vermelho", "Gasolina", 
                              250, 8.5f);
      Carro carro4 = new Carro("Tesla", "Model 3", "Preto", "Elétrico", 
                                210, 5.5f);
      Carro carro5 = new Carro("Chevrolet", "Onix", "Azul", "Gasolina", 
                                170, 6.0f);

      // Instancias dos onibus
      Onibus onibus1 = new Onibus("Mercedes-Benz", "Monobloco", "Azul", 
                                  "Diesel", 120, 5.0f);
      Onibus onibus2 = new Onibus("Volvo", "B12M", "Branco", 
                                        "Diesel", 110, 4.5f);
      Onibus onibus3 = new Onibus("Scania", "K440", "Vermelho", 
                                        "Diesel", 130, 6.0f);
      Onibus onibus4 = new Onibus("Volkswagen", "15.190", "Amarelo", 
                                        "Diesel", 100, 4.0f);
      Onibus onibus5 = new Onibus("MAN", "Lion’s Coach", "Verde", 
                                        "Diesel", 140, 6.5f);

      // Acelerar a moto
      moto1.Acelerar(10.0f);  
      moto2.Acelerar(12.5f);
      moto3.Acelerar(15.0f);
      moto4.Acelerar(8.0f);
      moto5.Acelerar(9.5f);

      // Para Carro
      carro1.Acelerar(15.0f);
      carro2.Acelerar(20.0f);
      carro3.Acelerar(18.0f);
      carro4.Acelerar(10.0f);
      carro5.Acelerar(12.0f);

      // Para Onibus
      onibus1.Acelerar(8.0f);
      onibus2.Acelerar(7.5f);
      onibus3.Acelerar(9.0f);
      onibus4.Acelerar(6.0f);
      onibus5.Acelerar(7.0f);
      

      // Exibir Velocidade Atual

      // Para Moto
      Console.WriteLine($"Moto1 Velocidade Atual: {moto1.VelocidadeAtual}");
      Console.WriteLine($"Moto2 Velocidade Atual: {moto2.VelocidadeAtual}");
      Console.WriteLine($"Moto3 Velocidade Atual: {moto3.VelocidadeAtual}");
      Console.WriteLine($"Moto4 Velocidade Atual: {moto4.VelocidadeAtual}");
      Console.WriteLine($"Moto5 Velocidade Atual: {moto5.VelocidadeAtual}");

      // Para Carro
      Console.WriteLine($"Carro1 Velocidade Atual: {carro1.VelocidadeAtual}");
      Console.WriteLine($"Carro2 Velocidade Atual: {carro2.VelocidadeAtual}");
      Console.WriteLine($"Carro3 Velocidade Atual: {carro3.VelocidadeAtual}");
      Console.WriteLine($"Carro4 Velocidade Atual: {carro4.VelocidadeAtual}");
      Console.WriteLine($"Carro5 Velocidade Atual: {carro5.VelocidadeAtual}");

      // Para Onibus
      Console.WriteLine($"Onibus1 Velocidade Atual: {onibus1.VelocidadeAtual}");
      Console.WriteLine($"Onibus2 Velocidade Atual: {onibus2.VelocidadeAtual}");
      Console.WriteLine($"Onibus3 Velocidade Atual: {onibus3.VelocidadeAtual}");
      Console.WriteLine($"Onibus4 Velocidade Atual: {onibus4.VelocidadeAtual}");
      Console.WriteLine($"Onibus5 Velocidade Atual: {onibus5.VelocidadeAtual}");
    }
  }
}
