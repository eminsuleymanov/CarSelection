
using CarSelection.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSelection.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Car> cars = new List<Car>
            {
                new Car{ Id = 1,Model ="M5",Brand = "BMW" ,Year =2022 ,ModelId = 1 },
                new Car{ Id = 1,Model ="X5",Brand = "BMW" ,Year =2022 ,ModelId = 2},
                new Car{ Id = 1,Model ="Z4",Brand = "BMW" ,Year =2022 ,ModelId = 3},
                new Car{ Id = 2,Model ="CLS",Brand = "Mercedes" ,Year =2022 ,ModelId = 4},
                new Car{ Id = 2,Model ="GLE class",Brand = "Mercedes" ,Year =2022 ,ModelId = 5},
                new Car{ Id = 2,Model ="ML class",Brand = "Mercedes" ,Year =2022 , ModelId = 6 },
                new Car{ Id = 2,Model ="C200",Brand = "Mercedes" ,Year =2000 ,ModelId = 7},
                new Car{ Id = 3,Model ="Cayenne",Brand = "Porsche" ,Year =2022 ,ModelId = 8},
                new Car{ Id = 3,Model ="Panamera",Brand = "Porsche" ,Year =2022 , ModelId =9},
                new Car{ Id = 3,Model ="911 Carrera",Brand = "Porsche" ,Year =2022 ,ModelId = 10},

            };

            return View(cars);
        }
    }
}

