using Microsoft.AspNetCore.Mvc; 

namespace Moment2NET.Controllers;

public class HomeController : Controller 
{
    public IActionResult Index() {
        return View(); 
    }

    public IActionResult Info() {
        return View(); 
    }

    public IActionResult Data() {
        return View(); 
    }
}