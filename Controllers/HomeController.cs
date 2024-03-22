using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Moment2NET.Models;

namespace Moment2NET.Controllers;

public class HomeController : Controller 
{
    public IActionResult Index() {
        return View(); 
    }

    public IActionResult Info() {
            string jsonStr = System.IO.File.ReadAllText("data.json");
            var data = JsonSerializer.Deserialize<List<DataModel>>(jsonStr);
        return View(data); 
    }
    public IActionResult Data() {
        return View(); 
    }


    [HttpPost]
    public IActionResult Data(DataModel model) 
    {
        if(ModelState.IsValid) {
            string jsonStr = System.IO.File.ReadAllText("data.json");
            var data = JsonSerializer.Deserialize<List<DataModel>>(jsonStr);
            
            if (data != null)
            {
                data.Add(model);
                jsonStr = JsonSerializer.Serialize(data);
                System.IO.File.WriteAllText("data.json", jsonStr);
            }
            ModelState.Clear(); 
            return RedirectToAction("Info", "Home");


        } 

        return View(); 
    }


}