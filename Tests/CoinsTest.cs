using System.Collections.Generic;
using System;
using Xunit;

namespace Coins
{
  public class CoinsTest
  {
    [Fact]
    public void Test_ReturnAmount_True()
    {
      int anyAmount = 94;
      Coins testAny = new Coins(anyAmount);
      List<string> outputAmount = testAny.Change();
      List<string> check = new List<string> {"1 quarter(s)"};

      Assert.Equal(check, outputAmount);
    }
  }
}
