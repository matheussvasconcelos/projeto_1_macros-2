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
        Console.WriteLine("Querido {0}, você deve ingerir no mínimo {1} gramas de PROTEÍNA por dia", Matheus.nome, valor);
      break;
      
      case "agua":
        valor = Macronutrientes.Agua(Matheus.peso);
        Console.WriteLine("Querido {0}, você deve ingerir no mínimo {1} Litros de ÁGUA por dia", Matheus.nome, valor);
      break;

      default:
        Console.WriteLine("Macro Invalido!");
      break;
    }
    
    // cara, vc me deu uma puta aula aqui agr !! vlwwww
    // algumas coisas nao entendi mto bem, como por exemplo "case", "Switch" e tals, mas de resto pqp, mto bom!
    // Deu pra entender ai ? Entra discord ai ok
    // o Switch o professor tinha explicado po, mas tu pode usar o if else tbm, coloquei Switch, so pra sair do basico mesmo, ja que o C# tem o Switch 
  }
}