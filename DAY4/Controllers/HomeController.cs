using Day3_Task1_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Day3_Task1_.Controllers
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
            _logger.LogInformation("Index Action is Processed.");
            _logger.LogError("Error Message");


            List<Employee> lstemps = new List<Employee>();

            lstemps[3].Ename = "Scott";

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