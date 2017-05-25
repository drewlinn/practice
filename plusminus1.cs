using System;

class PlusMinus1
{
  static void Main()
  {
    Console.WriteLine("Enter a number!");
    string userInput = Console.ReadLine();
    int userInt = int.Parse(userInput);

    if (userInt >= 0) {
      int output = userInt + 1;
      Console.WriteLine(output);
    }
    else  {
      int output = userInt -1;
      Console.WriteLine(output);
    };
  }
}
