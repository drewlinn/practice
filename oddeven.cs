using System;

class Practice
{
  static void Main()
  {
    Console.WriteLine("Please enter a number:");
    string userInput = Console.ReadLine();
    int userInputInt = int.Parse(userInput);

    Console.WriteLine("Check this out!");
    for (int index = 0; index <= userInputInt; index ++)
    {
      if (index % 2 == 0)
      {
        Console.WriteLine(index + " is even");
      }
      else
      {
        Console.WriteLine(index + " is odd");
      }
    }
  }
}
