using System;
using Locadora.ValueObjects;

namespace Locadora.Entities.Client
{
  public class Client
  {
    public Client(long code,
                  string name,
                  CPF cpf)
    {
      Name = name ?? throw new ArgumentNullException("O campo nome é obrigatório"); ;
      CPF = cpf ?? throw new ArgumentNullException("O campo cpf é obrigatório");
    }
    public long Code { get; private set; }
    public string Name { get; private set; }
    public CPF CPF { get; private set; }
  }
}