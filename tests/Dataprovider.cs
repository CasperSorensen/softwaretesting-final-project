using System;
using System.Collections.Generic;
using NUnit;
using NUnit.Framework;


namespace tests
{
  public class Dataprovider
  {
    public static IEnumerable<TestCaseData> HeightTestCases
    {
      get
      {
        yield return new TestCaseData(20, 4).Returns(5);
        yield return new TestCaseData(12, 2).Returns(6);
        yield return new TestCaseData(12, 4).Returns(3);
        // yield return new TestCaseData(0, 0)
        //   .SetName("DivideByZero")
        //   .SetDescription("An exception is expected");
      }
    }
  }
}