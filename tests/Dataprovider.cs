using System;
using System.Collections.Generic;
using app.Models;
using NUnit;
using NUnit.Framework;



namespace tests
{
  public class Dataprovider
  {

    #region Properties

    // Valid Users
    public static UserModel Userheight300 = new UserModel() { Height = 300 };
    public static UserModel Userheight299 = new UserModel() { Height = 299 };
    public static UserModel Userheight51 = new UserModel() { Height = 51 };
    public static UserModel Userheight50 = new UserModel() { Height = 50 };

    // Invalid Users
    public static UserModel Userheight301 = new UserModel() { Height = 301 };
    public static UserModel Userheight49 = new UserModel() { Height = 49 };
    public static UserModel Userheight0 = new UserModel() { Height = 0 };
    public static UserModel UserheightMinus10 = new UserModel() { Height = -10 };

    public Tuple<UserModel, int> test = new Tuple<UserModel, int>(Userheight0, 0);
    
    #endregion

    #region UserTestList

    public static IEnumerable<TestCaseData> UserTestList
    {
      get
      {
        yield return new TestCaseData(Userheight300).Returns(true);
        yield return new TestCaseData(Userheight299).Returns(true);
        yield return new TestCaseData(Userheight51).Returns(true);
        yield return new TestCaseData(Userheight50).Returns(true);
        yield return new TestCaseData(Userheight301).Returns(false);
        yield return new TestCaseData(Userheight49).Returns(false);
        yield return new TestCaseData(Userheight0).Returns(false);
        yield return new TestCaseData(UserheightMinus10).Returns(false);
      }
    }

    #endregion
  }
}