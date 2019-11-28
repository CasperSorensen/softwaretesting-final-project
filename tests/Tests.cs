using NUnit.Framework;

namespace tests
{
  [TestFixture]
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      Assert.Pass();
    }

    public class MyTests
    {
      [Test, TestCaseSource(typeof(Dataprovider), "HeightTestCases")]
      public int DivideTest(int n, int d)
      {
        return n / d;
      }
    }

  }
}