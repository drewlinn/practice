using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Let's play PingPong! Please enter a number:");
    string userInput = Console.ReadLine();
    int inputInt = int.Parse(userInput);

    for (int index = 0; index <= inputInt; index ++)
    {
      if (index % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (index % 15 == 0)
      {
        Console.WriteLine("PingPong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}
