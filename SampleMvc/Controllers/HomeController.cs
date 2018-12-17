using Microsoft.AspNetCore.Mvc;
using SampleMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SampleMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //generate mock sample data
            List<SampleClassModel> sampleData = new List<SampleClassModel>();
            for (var i = 0; i < 10; i++)
            {
                sampleData.Add(new SampleClassModel
                {
                    Id = i,
                    Name = $"Test {i.ToString()}",
                    Description = $"Test {i.ToString()} Description",
                    Timestamp = DateTime.Now.AddDays(Convert.ToInt32(i))
                });
            }

            return View(sampleData);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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