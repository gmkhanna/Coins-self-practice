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
        int quanQuar = total / 25;
        string quarterStr = quanQuar.ToString() + " quarter(s)";
        _coinList.Add(quarterStr);

        int dimeQuan = (total - (quanQuar * 25)) / 10;
        string dimeStr = dimeQuan.ToString() + " Dime(s)";
        _coinList.Add(dimeStr);

        int nickelQuan = (total - (quanQuar * 25) - (dimeQuan * 10)) / 5;
        string nickelStr = nickelQuan.ToString() + " Nickel(s)";
        _coinList.Add(nickelStr);

        int pennyQuan = (total - (quanQuar * 25) - (dimeQuan * 10) - (nickelQuan * 5)) / 1;
        string pennyStr = pennyQuan.ToString() + " pennie(s)";
        _coinList.Add(pennyStr);
      }
      return _coinList;
    }
  }
}
