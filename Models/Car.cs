
namespace Dealership.Models
{
  public class Car 
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _description;

    public Car(string makeModel, int price, int miles, string description)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _description = description;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

     public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public bool GoodMilage(int maxMilage)
    {
      return (_miles < maxMilage);
    }
  }
}
