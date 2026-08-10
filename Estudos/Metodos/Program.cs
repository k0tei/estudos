// Feito Por Valentina Moraes Binding  e Samuel Henrique Alves de Souza
namespace ExercicioDeFixacao
{
  class Jogo
  {
    static void Main(string[] args)
    {
      // Instancias dos magos
      Mago mago1 = new Mago
      (
        vida: 70f,
        vidaMaxima: 70f,
        velocidade: 5f,
        velocidadeDeAtaque: 1.2f,
        ataque: 15f,
        defesa: 5f,
        mana: 100f,
        nivel: 5,
        inteligencia: 18
      );
      Mago mago2 = new Mago
      (
        vida: 60f,
        vidaMaxima: 60f,
        velocidade: 4.5f,
        velocidadeDeAtaque: 1.0f,
        ataque: 12f,
        defesa: 6f,
        mana: 120f,
        nivel: 6,
        inteligencia: 20
      );
      Mago mago3 = new Mago
      (
        vida: 65f,
        vidaMaxima: 65f,
        velocidade: 6f,
        velocidadeDeAtaque: 1.5f,
        ataque: 14f,
        defesa: 4f,
        mana: 110f,
        nivel: 5,
        inteligencia: 19
      );

      // Instancias dos Zumbis
      Zumbi zumbi1 = new Zumbi
      (
        vida: 8,         
        vidaMaxima: 12,  
        velocidade: 2.0f, 
        velocidadeDeAtaque: 0.6f, 
        ataque: 4,       
        defesa: 6,       
        nivel: 3,        
        infeccao: 2,     
        regeneracao: 2,  
        resistencia: 7    
      );
      Zumbi zumbi2 = new Zumbi
      (
        vida: 12,        
        vidaMaxima: 15,  
        velocidade: 2.8f, 
        velocidadeDeAtaque: 0.8f, 
        ataque: 6,       
        defesa: 8,       
        nivel: 5,        
        infeccao: 3,     
        regeneracao: 3,  
        resistencia: 10   
      );

      Zumbi zumbi3 = new Zumbi
      (
        vida: 15,        
        vidaMaxima: 15,  
        velocidade: 3.9f, 
        velocidadeDeAtaque: 2.8f, 
        ataque: 2,       
        defesa: 3,       
        nivel: 6,        
        infeccao: 7,     
        regeneracao: 5,  
        resistencia: 8   
      );
      // Instâncias dos Soldados
      Soldado soldado1 = new Soldado
      (
          vida: 100f,
          vidaMaxima: 100f,
          velocidade: 4.5f,
          velocidadeDeAtaque: 1.0f,
          ataque: 20f,
          defesa: 10,
          nivel: 1,
          municao: 30,
          municaoTotal: 30,
          forca: 15,
          critico: 5
      );

      Soldado soldado2 = new Soldado
      (
          vida: 90f,
          vidaMaxima: 90f,
          velocidade: 4.0f,
          velocidadeDeAtaque: 1.2f,
          ataque: 18f,
          defesa: 12,
          nivel: 2,
          municao: 25,
          municaoTotal: 25,
          forca: 14,
          critico: 6
      );

      Soldado soldado3 = new Soldado
      (
          vida: 80f,
          vidaMaxima: 80f,
          velocidade: 5.0f,
          velocidadeDeAtaque: 1.5f,
          ataque: 22f,
          defesa: 8,
          nivel: 3,
          municao: 20,
          municaoTotal: 20,
          forca: 16,
          critico: 4
      );
    }
  }
}
