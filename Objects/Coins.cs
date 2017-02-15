using System;
using System.Collections.Generic;

namespace Coins
{
  public class Coins
  {
    private int _amount;
    private List<string> _coinList = new List<string>();

    public Coins(int amount)
    {
      _amount = amount;
    }

    public List<string> Change()
    {
      int total = _amount;
      if( (total > 0) & (total < 100) )
      {
        Random Random = new Random();
        int quanQuar = total / 25;
        int quarters = Random.Next(0, quanQuar);
        string quarterStr = quarters.ToString() + " quarter(s)";
        _coinList.Add(quarterStr);
        int dimeQuan = (total - (quarters * 25)) / 10;
        int dimes = Random.Next(0, dimeQuan);
        string dimeStr = dimes.ToString() + " Dime(s)";
        _coinList.Add(dimeStr);
        int nickelQuan = (total - (quarters * 25) - (dimes * 10)) / 5;
        int nickels = Random.Next(0, nickelQuan);
        string nickelStr = nickels.ToString() + " Nickel(s)";
        _coinList.Add(nickelStr);
        int pennyQuan = (total - (quarters * 25) - (dimes * 10) - (nickels * 5)) / 1;
        string pennyStr = pennyQuan.ToString() + " pennie(s)";
        _coinList.Add(pennyStr);
      }
      return _coinList;
    }
  }
}
