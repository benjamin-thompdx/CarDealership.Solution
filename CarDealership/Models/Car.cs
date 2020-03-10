using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car 
  {
    public string MakeModel { get; set; }
    public int Price {get; set; }
    public int Miles {get; set; }
    public string Description {get; set; }
    private static List<Car> _newCar = new List<Car>{};

    public Car(string makeModel, int price, int miles, string description)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = description;
      _newCar.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _newCar;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

     public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetDescription()
    {
      return Description;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
    public bool GoodMilage(int maxMilage)
    {
      return (Miles < maxMilage);
    }
  }
}
