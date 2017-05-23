using System;
using System.Collections.Generic;

class Restaurant {
  public string Name;
  public bool Vegan;
  public bool PeanutFree;
  public bool Organic;

  public Restaurant(string restaurantName, bool restaurantVegan, bool restaurantPeanutFree, bool restaurantOrganic)
  {
    Name = restaurantName;
    Vegan = restaurantVegan;
    PeanutFree = restaurantPeanutFree;
    Organic = restaurantOrganic;
  }
}

class Program
{
  public static void Main()
  {
    Restaurant firstRestaurant = new Restaurant("Shaney's", False, False, False);
    Restaurant secondRestaurant = new Restaurant("Little Bits", False, False, True);
    Restaurant thirdRestaurant = new Restaurant("Blips and Chips!", True, True, True);
    Restaurant fourthRestaurant = new Restaurant("Elefante", True, False, True);

    List<Restaurant> Restaurants = new List<Restaurant> { firstRestaurant, secondRestaurant, thirdRestaurant };

    Restaurants.Add(fourthRestaurant);

    foreach (Restaurant place in Restaurants)
    {
      Console.WriteLine(restaurantName);
      Console.WriteLine(restaurant.Vegan);
      Console.WriteLine(restaurant.PeanutFree);
      Console.WriteLine(restaurant.Organic);
    }
  }
}
