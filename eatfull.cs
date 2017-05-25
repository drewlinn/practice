using System;

class EatFull
{
  static void Main()
  {
    string[] faveFoods = {"pizza", "burgers", "fries", "burritos", "tacos", "sandwiches", "pasta", "pad thai", "sushi", "soup"};

    for (string food = 0; food <= faveFoods.Length(); food ++)
    {
      Console.WriteLine("I am eating" + food);
      if (food == 9)
      {
        Console.WriteLine("I am full!");
      }
    }
  }
}
