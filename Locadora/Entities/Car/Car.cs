using System;

namespace Locadora.Entities.Car
{
  public class Car
  {
    public Car(string model,
               string brand,
               string color,
               decimal price)
    {
      Model = model ?? throw new ArgumentNullException("O campo nome é obrigatório"); ;
      Brand = brand;
      Color = color;
      Price = price;
      IsAvailable = true;
    }

    public long Code { get; private set; }
    public string Model { get; private set; }
    public string Brand { get; private set; }
    public string Color { get; private set; }
    public decimal Price { get; private set; }
    public bool IsAvailable { get; private set; }

    public void Rent(long code)
    {

    }
  }
}
