namespace ExercicioDeFixacao
{
    class Zumbi
    {
        private float _vida;
        private float _vidaMaxima;
        private float _velocidade;
        private float _velocidadeDeAtaque;
        private int _ataque;
        private int _defesa;
        private int _infeccao;
        private int _nivel;
        private int _regeneracao;
        private int _resistencia;

        public Zumbi(float vida, float vidaMaxima, float velocidade, float velocidadeDeAtaque, int ataque,
                     int defesa, int infeccao, int nivel, int regeneracao, int resistencia)
        {
            Vida = vida;
            _vidaMaxima = vidaMaxima;
            _velocidade = velocidade;
            _velocidadeDeAtaque = velocidadeDeAtaque;
            _ataque = ataque;
            _defesa = defesa;
            _infeccao = infeccao;
            _nivel = nivel;
            _regeneracao = regeneracao;
            _resistencia = resistencia;
        }

        public float Vida
        {
            get { return _vida; }
            set
            {
                if (value <= 0)
                {
                    _vida = 0;
                    Morrer();
                }
                else if (value > _vidaMaxima)
                {
                    _vida = _vidaMaxima;
                }
                else
                {
                    _vida = value;
                }
            }
        }

        public void Andar()
        {
          Console.WriteLine($"Zumbi está caminhando a uma velocidade de {_velocidade} metros por segundo.");
        }

        public void Defender()
        {
           _defesa *= 2; 
           Console.WriteLine($"Zumbi se defendeu! Defesa atual:{_defesa}");
        }
        public void Morrer()
        {
            _velocidade = 0;
            _nivel -= 1;
            Console.WriteLine("Zumbi morrendo...");
        }

        public void Atacar()
        {
            Console.WriteLine("Zumbi atacando!");
        }

        public void Infectar()
        {
          Console.WriteLine("O zombie está infectando o alvo!");
        }
        public void Regenerar()
        {
            Vida += _regeneracao;
            Console.WriteLine("Zumbi regenerando vida!");
        }
    }
}
