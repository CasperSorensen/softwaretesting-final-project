using System;
using System.Collections.Generic;
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

    #region CalcAvgHeightTests

    [Test]
    public void CalcAvgUserHeight_Pass()
    {
      this._testlist.CalculateAvgUserHeight();

      Assert.AreEqual(this._testlist.CalculateAvgUserHeight(), 176.80000000000001);
    }

    [Test, TestCaseSource(typeof(Dataprovider), "HeightTestList")]
    public void CalcAvgUserHeight_Fail(double in_value)
    {
      var avguserheight = this._testlist.CalculateAvgUserHeight();
      Assert.AreNotEqual(avguserheight, in_value);
    }

    #endregion

    #region AddNewUserTests

    #region Height Tests

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserHeightListPass")]
    public void AddNewUserHeight_Pass(UserModel newuser)
    {
      var res = this._testlist.AddNewUserOnHeight(newuser);
      if (res == true)
      {
        Assert.Pass();
      }
      Assert.Fail();
    }

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserHeightListFail")]
    public void AddNewUserHeight_Fail(UserModel newuser)
    {
      var res = this._testlist.AddNewUserOnHeight(newuser);

      if (res == false)
      {
        Assert.Pass();
      }
    }

    #endregion

    #region Age Tests

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserAgeListPass")]
    public void AddNewUserAge_Pass(UserModel newuser)
    {
      var user_added = this._testlist.AddNewUserOnAge(newuser);
      if (user_added == true)
      {
        Assert.Pass();
      }
      Assert.Fail();
    }

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserAgeListFail")]
    public void AddNewUserAge_Fail(UserModel newuser)
    {
      var user_added = this._testlist.AddNewUserOnAge(newuser);
      if (user_added == false)
      {
        Assert.Pass();
      }
      Assert.Fail();
    }

    #endregion

    #endregion

  }
}