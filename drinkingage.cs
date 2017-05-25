using System;

class DrinkingAge
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string stringUserAge = Console.ReadLine();
    int intUserAge = int.Parse(stringUserAge);

    if (intUserAge >=21)
    {
      Console.WriteLine("You can legally drink in the United States :D!");
    }
    else
    {
      Console.WriteLine("I'm sorry, you are too young to legally drink in the United States. :(");
    }
  }
}
