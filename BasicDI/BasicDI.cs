using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicDI.Models.Database;

namespace BasicDI
{
  public class BasicDI
  {
    private readonly DIEntities _diEntities;

    public DIEntities DIEntities { get { return _diEntities; } }

    public BasicDI(DIEntities diEntities)
    {
      _diEntities = diEntities;
    }

    public string SaySomething()
    {
      string userName = Models.Helper.UserName();
      if (string.IsNullOrWhiteSpace(userName))
      {
        userName = "No-Name-User";
      }
      return "Hello " + userName + "!";
    }
  }
}
