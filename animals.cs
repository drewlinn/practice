using System;
using System.Collections.Generic;

class Animal {
  public string Species;
  public string Age;
}

class Program
{
  public static void Main()
  {
    Animal Schneider = new Animal();
    Schneider.Species = "Hack";
    Schneider.Age = "12"; //emotionally

    Animal Trump = new Animal();
    Trump.Species = "Total fucking monster";
    Trump.Age = "7";

    Animal Rand = new Animal();
    Rand.Species = "Objectivist";
    Rand.Age = "300";
  }
}
