namespace DotNetBackend.Services {
  public class UserService {
    public string GetUserRole(string username) => username == "admin" ? "Admin" : "User";
  }
}
