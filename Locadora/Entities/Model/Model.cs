namespace Locadora.Entities.Model
{
  public class Model
  {
    public Model(string name)
    {
      Name = name ?? throw new ArgumentNullException("O campo nome do modelo é obrigatório");
      isAvailable = true;
    }
    public long Code { get; private set; }
    public string Name { get; private set; }
    public bool isAvailable { get; private set; }

  }
}