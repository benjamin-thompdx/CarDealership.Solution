using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet ("/cars/priceForm")]
    public ActionResult PriceForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string description)
    {
      Car myCar = new Car(makeModel, price, miles, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/byPrice")]
    public ActionResult Create(int searchPrice)
    {
  
      return RedirectToAction("Index");
    }
  }
}