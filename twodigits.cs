using System;

class TwoDigits
{
  static void Main()
  {
    Console.WriteLine("Enter a whole number:");
    string inputString = Console.ReadLine();
    int inputInt = int.Parse(inputString);
    if (inputInt > 9 && inputInt < 100) {
      Console.WriteLine("Congratulations, you have successfully provided a two digit number!");
    }
    else {
      Console.WriteLine("I'm sorry, you have failed to write a two digit number. Better luck next time!");
    }
  }
}
