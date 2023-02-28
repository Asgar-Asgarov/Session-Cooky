using Microsoft.AspNetCore.Mvc;

namespace FronToBack.Controllers;

public class BasketController:Controller
{
    public IActionResult Index()
    {
        HttpContext.Session.SetString("name","Asgar");
        return Content("set olundu");
    }

        public IActionResult GetItem()
    {
       string name = HttpContext.Session.GetString("name");
        return Content(name);
    }

    
}