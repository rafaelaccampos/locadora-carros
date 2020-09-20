namespace Locadora.Entities.Client
{
  public class Client
  {
    public Client(long code,
                  string name,
                  Documento documento)
    {
      Name = name ?? throw new ArgumentNullException("O campo nome é obrigatório"); ;
      Documento = throw new ArgumentNullException("O campo cpf é obrigatório"); documento;
    }
    public long Code { get; private set; }
    public string Name { get; private set; }
    public Documento Documento { get; private set; }
  }
}