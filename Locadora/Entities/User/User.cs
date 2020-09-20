using System;

namespace Locadora.Entities.User
{
  public class User
  {
    public User(string name, string username, string password)
    {
      Name = name ?? throw new ArgumentNullException("O campo nome é obrigatório.");
      Username = username ?? throw new ArgumentNullException("O campo nome do usuário é obrigatório");
      Password = password ?? throw new ArgumentNullException("O campo senha é obrigatório");
    }
    public long Code { get; private set; }
    public string Name { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
  }
}