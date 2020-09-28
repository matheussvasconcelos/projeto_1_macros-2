using System;

class Individuo {
  public string nome;
  public int idade;
  public double altura;
  public double peso;

  public void CadastraInfo(string _nome, int _idade, double _altura, double _peso){
    nome = _nome;
    idade = _idade;
    altura = _altura;
    peso = _peso;
  }

}