using Imi.Project.Vue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Vue.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Characters()
        {
            return View();
        }

        public IActionResult Dungeons()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }

        public IActionResult ExternAPI()
        {
            return View();
        }
    }
}
