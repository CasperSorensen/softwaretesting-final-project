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


    public Tuple<UserModel, int> test = new Tuple<UserModel, int>(Userheight0, 0);
    
    #endregion

    #region UserTestList

    public static IEnumerable<TestCaseData> HeightTestList
    {
      get
      {
        // the avg height is 174.5
        yield return new TestCaseData(-10);
        yield return new TestCaseData(0);
        yield return new TestCaseData(174);
        yield return new TestCaseData(175);

      }
    }

    public static IEnumerable<TestCaseData> NewUserHeightListPass
    {
      get
      {
        UserModel testuser1 = new UserModel() { Height = 300 };
        UserModel testuser2 = new UserModel() { Height = 299 };
        UserModel testuser3 = new UserModel() { Height = 200 };
        UserModel testuser4 = new UserModel() { Height = 51 };
        UserModel testuser5 = new UserModel() { Height = 50 };

        yield return new TestCaseData(testuser1);
        yield return new TestCaseData(testuser2);
        yield return new TestCaseData(testuser3);
        yield return new TestCaseData(testuser4);
        yield return new TestCaseData(testuser5);

      }
    }

    public static IEnumerable<TestCaseData> NewUserHeightListFail
    {
      get
      {
        UserModel testuser1 = new UserModel() { Height = 301 };
        UserModel testuser2 = new UserModel() { Height = 49 };
        UserModel testuser3 = new UserModel() { Height = 0 };
        UserModel testuser4 = new UserModel() { Height = -10 };

        yield return new TestCaseData(testuser1);
        yield return new TestCaseData(testuser2);
        yield return new TestCaseData(testuser3);
        yield return new TestCaseData(testuser4);

      }
    }

    #endregion
  }
}