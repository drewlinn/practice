using System;

class Encrypt
{
  static void Main()
  {
    Console.WriteLine("Enter a word or phrase in letters and we will convert it into a strange new code:");
    string userEntry = Console.ReadLine();
    string encrypt = userEntry.Replace("a", "z").Replace("b", "y").Replace("c", "x").Replace("d", "w").Replace("e", "v").Replace("f", "u").Replace("g", "t").Replace("h", "s").Replace("i", "r").Replace("j", "q").Replace("k", "p").Replace("l", "o").Replace("m", "n").Replace("n", "m").Replace("o", "l").Replace("p", "k").Replace("q", "j").Replace("r", "i").Replace("s", "h").Replace("t", "g").Replace("u", "f").Replace("v", "e").Replace("w", "d").Replace("x", "c").Replace("y", "b").Replace("z", "a");   Console.WriteLine(encrypt);
  }
}
