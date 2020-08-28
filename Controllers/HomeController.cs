using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hello_world.Models;
using Newtonsoft.Json;

namespace hello_world.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

     
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static User _User = new User
        {
            Username = " ",
            Fullname = " ",
            Password = " ",
            Email = " ",
        };
    public IActionResult Volunteer(){
        
        return View(_User);
    }


    
   public IActionResult Animals()
        {
                return View();
        }
        [Route ("")]
        [Route("Home")]
        [Route("Home/index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
