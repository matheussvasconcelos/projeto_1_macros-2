using System;

class MainClass {
  public static void Main () {
    Individuo Matheus = new Individuo();
    
    Console.Write("Informe seu nome: ");
    string nome = Console.ReadLine();

    Console.Write("Informe sua idade: ");
    int idade = int.Parse( Console.ReadLine() );

    Console.Write("Informe sua altura: ");
    double altura = double.Parse( Console.ReadLine() );

    Console.Write("Informe seu peso: ");
    double peso = double.Parse( Console.ReadLine() );

    Matheus.CadastraInfo( nome, idade, altura, peso );

    Console.Write("Informe qual macro deseja calcular (proteina ou agua) : ");
    string macro = Console.ReadLine();

    double valor;

    switch(macro){
      case "proteina":
        valor = Macronutrientes.Proteina(Matheus.peso);
        Console.WriteLine("Querido(a) {0}, você deve ingerir no mínimo {1} gramas de PROTEÍNA por dia", Matheus.nome, valor);
        Console.ReadLine();
      break;
      
      case "agua":
        valor = Macronutrientes.Agua(Matheus.peso);
        Console.WriteLine("Querido(a) {0}, você deve ingerir no mínimo {1} Litros de ÁGUA por dia", Matheus.nome, valor);
        Console.ReadLine();
      break;

      default:
        Console.WriteLine("Macro Invalido!");
        Console.ReadLine();
      break;
    }
  }
}