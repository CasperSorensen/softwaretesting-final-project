using NUnit.Framework;
using app;
using app.Models;

namespace tests
{
  [TestFixture]
  public class Tests
  {

    private UserDummies _testlist;

    [SetUp]
    public void Setup()
    {
      this._testlist = new UserDummies();
    }

    #region AddNewUserTests

    [Test, TestCaseSource(typeof(Dataprovider), "UserTestList")]
    public bool AddNewUserTest_Height(UserModel testuser)
    {
      Assert.Equals(testuser.Height, 300);
    }

    #endregion

  }
}