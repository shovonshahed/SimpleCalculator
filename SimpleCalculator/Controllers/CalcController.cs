using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Models;

namespace SimpleCalculator.Controllers;

public class CalcController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View(new Calc());
    }
    
    [HttpPost]
    public IActionResult Index(Calc c, string calculate)
    {
        if (calculate == "add")
        {
            c.Tot = c.No1 + c.No2;
        }
        else if (calculate == "sub")
        {
            c.Tot = c.No1 - c.No2;
        }
        else if (calculate == "multi")
        {
            c.Tot = c.No1 * c.No2;
        }
        else if (calculate == "div")
        {
            c.Tot = c.No1 / c.No2;
        }

        return View(c);
    }
    
}