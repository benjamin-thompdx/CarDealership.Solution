
namespace Models
{
  public class Car 
  {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Description;

    public Car(string makeModel, int price, int miles, string description)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = description;
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
