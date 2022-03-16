using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_SysInfo_UserManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SysInfo_UserManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username)
        {
            if (UserData.Exists(username))
            {
                HttpContext.Session.SetString("username", username);
                return Redirect("/Home/details");
            }
            else
            {
                ViewBag.error = $"User with {username} does not exsit in";
                    return View();
            }

        }
      

        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login");

        }

        public IActionResult Login()
        {
            return View();
        }

       

       
    }
}
