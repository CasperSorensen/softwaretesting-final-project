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
      if (this._testlist.AddNewUser(testuser))
        return true;
      else
      {
        return false;
      }
    }

    #endregion

  }
}