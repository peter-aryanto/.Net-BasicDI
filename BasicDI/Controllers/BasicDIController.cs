using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicDI.Controllers
{
  [Route("api/[controller]")]
  public class BasicDIController : Controller
  {
    /*
    public IActionResult Index()
    {
      return View();
    }
    */

    private readonly BasicDI _basicDI;

    public BasicDIController(BasicDI basicDI)
    {
      _basicDI = basicDI;
    }

    public IActionResult Get()
    {
      return Ok(
        new
        {
          Result = "Hello World!" + " " + _basicDI.SaySomething(),
        }
      );
    }
  }
}
