using System;

class Calculate
{
  static void Main()
  {
    Console.WriteLine("Enter a number:");
    string firstString = Console.ReadLine();
    int firstNumber = int.Parse(firstString);

    Console.WriteLine("Enter another number:");
    string secondString = Console.ReadLine();
    int secondNumber = int.Parse(secondString);

    Console.WriteLine("Please enter an operator symbol for the type of mathematical operation you would like to perform:");
    string operatorSymbol = Console.ReadLine();
    {
      if (operatorSymbol == "+")
      {
        int yourAnswer = firstNumber + secondNumber;
        Console.WriteLine(yourAnswer);
      }
      else if (operatorSymbol == "-")
      {
        int yourAnswer = firstNumber - secondNumber;
        Console.WriteLine(yourAnswer);
      }
      else if (operatorSymbol == "*")
      {
        int yourAnswer = firstNumber * secondNumber;
        Console.WriteLine(yourAnswer);
      }
      else if (operatorSymbol == "/")
      {
        int yourAnswer = firstNumber / secondNumber;
        Console.WriteLine(yourAnswer);
      }
      else
      {
        Console.WriteLine("Please enter a valid operator symbol!");
        Main();
      }
    }
  }
}
