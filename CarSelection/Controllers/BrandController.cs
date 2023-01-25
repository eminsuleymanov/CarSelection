
using CarSelection.Models;
using Microsoft.AspNetCore.Mvc;


namespace CarSelection.Controllers
{
    public class BrandController : Controller
    {
        
        public IActionResult Index()
        {
            List<Brand> brands = new List<Brand>
            {
                new Brand {Name = "BMW",Id =1},
                new Brand {Name = "Mercedes",Id =2},
                new Brand {Name = "Porsche",Id =3}
            };
            return View(brands);
            
        }
    }
}

