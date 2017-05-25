using System;

class MyFriends
{
  static void Main()
  {
    string[] myFriends = {"Gabe", "Pete", "Catlin", "Faolan", "Ben", "Tyler", "Sacha", "Jesse", "Drew", "Glenn", "Nina"};

    Console.WriteLine("My friends!");
    foreach (string friend in myFriends)
    {
      Console.WriteLine(friend + " is my friend!");
    }
  }
}
