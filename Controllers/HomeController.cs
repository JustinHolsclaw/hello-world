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

   public string Contact()
        {
            var user = new User {
                Username = "Todd",
                Fullname = "Todd Menster",
                Password = "My secure password."};
                var json = JsonConvert.SerializeObject(user, Formatting.Indented);

                return json;
        }

        public IActionResult Index()
        {
            return View();
        }

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
