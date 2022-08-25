using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicDI
{
  public class BasicDI
  {
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
