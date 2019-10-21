using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DetectiveAgency.Models;

namespace DetectiveAgency.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index()
        {
            
            return View();
        }

        public ViewResult MapPage()
        {
            return View();
        }

        public ViewResult GetOrder()
        {
            return View();
        }

        [HttpGet]
        public ViewResult FillDB()
        {
            return View();
        }

        [HttpPost("users/create")]
        public IActionResult CreateUser(UserModel model)
        {
            var user = new User
            {
                Name = model.Name,
                Age = model.Age
            };
            repository.Add(user);
            return Redirect("~/home/FillDB");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
