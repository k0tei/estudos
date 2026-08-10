

using System;

namespace Veiculos
{
  class Onibus
  {
    private int _rodas;
    private int _cilindradas;
    private float _capacidadeTanque;
    private float _capacidadePassageiros;
    private float _aceleracao;
    private float _velocidadeMaxima;
    private float _velocidadeAtual;
    private string _marca;
    private string _modelo;
    private string _cor;
    private string _propulsao;

    public Onibus(string marca, string modelo, string cor, string propulsao,
                float velocidadeMaxima, float aceleracao)
    {
      Marca = marca ;
      Modelo = modelo; 
      Cor = cor; 
      Aceleracao = aceleracao;
      _velocidadeMaxima = velocidadeMaxima;
      _rodas = 6;
      _propulsao = propulsao;     
    }
    public string Marca 
    {
      get{ return _marca; }
      set{ _marca = value; }
    }
    public string Cor 
    {
      get { return _cor; }
      set { _cor = value; }
    }
    public string Modelo 
    {
      get { return _modelo; }
      set { _modelo = value; }
    }
    public float VelocidadeAtual
    {
      get { return _velocidadeAtual; }
      set {
        if (_velocidadeAtual > _velocidadeMaxima)
        {
          _velocidadeAtual = _velocidadeMaxima;
        }
        else 
        {
        _velocidadeAtual = value; 
        }
      }
    }
    public float Aceleracao 
    {
      get {return _aceleracao; }
      set { _aceleracao = value; }
    }

    public void Acelerar (float aceleracao)
    {
      VelocidadeAtual += aceleracao;
    }
  }
}

