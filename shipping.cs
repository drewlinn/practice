using System;

class Shipping
{
  static void Main()
  {

    Console.WriteLine("We're going to help you calculate how much it will cost to ship your package! Enter the weight of your package in lbs:");
    string enteredWeight = Console.ReadLine();
    int weight = int.Parse(enteredWeight);

    Console.WriteLine("What is the distance (in miles) that your package needs to travel?");
    string enteredDistance = Console.ReadLine();
    int distance = int.Parse(enteredDistance);

    int pricingMod = (weight / 700) + (distance / 700);

    int shippingCost = (weight / 10) + (distance / 5) + pricingMod;

    Console.WriteLine("You've said your package weighs " + weight + " lbs. and that it needs to travel " + distance + " miles.");
    Console.WriteLine("It will cost " + "$" + shippingCost + " to ship your package.");
  }
}
