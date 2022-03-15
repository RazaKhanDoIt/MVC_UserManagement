using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_SysInfo_UserManagement.Models;
using MVC_SysInfo_UserManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SysInfo_UserManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Home/Add")]

        public IActionResult NewUser(string name, string description)
        {
            UserData.Add(new User(name, description));

            return Redirect("/Home/Details");
        }



        public IActionResult Details()
        {
            UserListViewModel model = new UserListViewModel
            {
                Users = new List<User>()
            };

            model.Users = UserData.GetAll();

           

            ViewData["Title"] = model.Title;
            ViewData["Name"] = "Raza";

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
