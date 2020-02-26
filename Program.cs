using System;
using System.Collections.Generic;
using Models;

namespace Dealership
{
    public class Program
    {
    public static void Main()
    {
        Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "wow! its groovay baby! ");
        Car yugo = new Car("1980 Yugo Koral", 700, 56000, "sexiest cerial box you can drive!");
        Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "'MerIca");
        Car amc = new Car("1976 AMC Pacer", 400, 198000, "ummmm");
        Car mazda = new Car("2002 Mazda 626", 2000, 110000, "my first car");

        List<Car> Cars = new List<Car>() {volkswagen, yugo, ford, amc, mazda};

        Console.Write("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);
        Console.Write("Enter maximum Milage: ");
        string stringMaxMilage = Console.ReadLine();
        int maxMilage = int.Parse(stringMaxMilage);

        List<Car> CarsMatchingSearch = new List<Car>(0);

        // compares all cars to price range, filtering out cars outside it
        foreach(Car automobile in Cars)
        {
        if (automobile.WorthBuying(maxPrice) && automobile.GoodMilage(maxMilage))
        {
            CarsMatchingSearch.Add(automobile);
        }
        }

        //prints out cars within price range
        foreach(Car automobile in CarsMatchingSearch)
        {
        Console.Write(automobile.MakeModel + ":");
        Console.WriteLine(" " + automobile.Description);
        }

        if (CarsMatchingSearch.Count == 0)
        {
        Console.WriteLine("Oops your a picky nicky");
        }
    }
    }
}