using System;

class Program {
  public static void Main (string[] args) {
  string entrada1, entrada2, entrada3;
  double num1, num2, num3, media;
  Console.WriteLine ("Digite a primeira nota: ");
  entrada1 = Console.ReadLine();
    num1 = Double.Parse(entrada1);
  Console.WriteLine ("Digite a segunda nota: ");
  entrada2 = Console.ReadLine();
    num2 = Double.Parse(entrada2);
  Console.WriteLine ("Digite a terceira nota: ");
  entrada3 = Console.ReadLine();
    num3 = Double.Parse(entrada3);
  media = (num1 *2 + num2 *3 + num3 *5) /10;
  Console.WriteLine(" A nota média do aluno é de :" + media);
  }
}