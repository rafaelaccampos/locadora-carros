namespace Locadora.Entities.User
{
  public class UserToken
  {
    public UserToken(long token, int userId)
    {
      Token = token;
      UserId = userId;
    }
    public long Code { get; private set; }
    public long Token { get; private set; }
    public int UserId { get; private set; }
  }
}