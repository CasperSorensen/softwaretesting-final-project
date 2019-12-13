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
        UserModel testuser6 = new UserModel() { Height = 301 };
        UserModel testuser7 = new UserModel() { Height = 49 };
        UserModel testuser8 = new UserModel() { Height = 0 };
        UserModel testuser9 = new UserModel() { Height = -10 };

        yield return new TestCaseData(testuser6);
        yield return new TestCaseData(testuser7);
        yield return new TestCaseData(testuser8);
        yield return new TestCaseData(testuser9);

      }
    }

    public static IEnumerable<TestCaseData> NewUserAgeListPass
    {
      get
      {
        UserModel testuser10 = new UserModel() { Age = 120 };
        UserModel testuser11 = new UserModel() { Age = 119 };
        UserModel testuser12 = new UserModel() { Age = 56 };
        UserModel testuser13 = new UserModel() { Age = 19 };
        UserModel testuser14 = new UserModel() { Age = 18 };

        yield return new TestCaseData(testuser10);
        yield return new TestCaseData(testuser11);
        yield return new TestCaseData(testuser12);
        yield return new TestCaseData(testuser13);
        yield return new TestCaseData(testuser14);

      }
    }

    public static IEnumerable<TestCaseData> NewUserAgeListFail
    {
      get
      {
        UserModel testuser15 = new UserModel() { Age = 121 };
        UserModel testuser16 = new UserModel() { Age = 17 };
        UserModel testuser17 = new UserModel() { Age = 0 };
        UserModel testuser18 = new UserModel() { Age = -10 };

        yield return new TestCaseData(testuser15);
        yield return new TestCaseData(testuser16);
        yield return new TestCaseData(testuser17);
        yield return new TestCaseData(testuser18);

      }
    }

    #endregion
  }
}