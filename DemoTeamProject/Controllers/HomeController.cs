﻿using DemoTeamProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoTeamProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
             _logger= logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //action Methods added by sudharshan
        public IActionResult about()
        {
            return View();
        }
        //action Methods added by sudharshan
        public IActionResult Contact()
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