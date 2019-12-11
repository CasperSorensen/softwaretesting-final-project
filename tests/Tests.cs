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

    #region AddNewUserTest

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserHeightListPass")]
    public void AddNewUserHeight_Pass(UserModel newuser)
    {
      if (this._testlist.AddNewUser(newuser))
      {
        Assert.Pass();
      }
    }

    [Test, TestCaseSource(typeof(Dataprovider), "NewUserHeightListFail")]
    public void AddNewUserHeight_Fail(UserModel newuser)
    {
      if (this._testlist.AddNewUser(newuser))
      {
        Assert.Fail();
      }
    }

    #endregion

    #region DateOnNewUser



    #endregion



  }
}