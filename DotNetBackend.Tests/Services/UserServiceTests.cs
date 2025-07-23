using Xunit;
using DotNetBackend.Services;

namespace DotNetBackend.Tests.Services {
  public class UserServiceTests {
    [Fact]
    public void Should_Return_Admin_For_Admin_User() {
      var service = new UserService();
      var role = service.GetUserRole("admin");
      Assert.Equal("Admin", role);
    }
  }
}
