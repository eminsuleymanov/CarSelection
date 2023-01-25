
using Microsoft.AspNetCore.Mvc;


namespace CarSelection.Controllers
{
    public class ModelController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

