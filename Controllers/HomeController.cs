using Microsoft.AspNetCore.Mvc;
using ProjectOne.Data;
using ProjectOne.Models;
using System.Diagnostics;

namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectOneContext _context;

        public HomeController(ProjectOneContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products);
        }


        /*       private readonly ILogger<HomeController> _logger;*/

        /*       public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

  /*      public IActionResult Index()
        {
            return View();
        }*/

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