using System;

namespace Locadora.Entities.Brand
{
  public class Brand
  {
    public Brand(string name)
    {
      Name = name ?? throw new ArgumentNullException("O campo nome da marca é obrigatório"); ;
      isAvailable = true;
    }
    public long Code { get; private set; }
    public string Name { get; private set; }
    public bool isAvailable { get; private set; }
  }
}