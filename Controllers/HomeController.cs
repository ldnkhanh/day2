using Microsoft.AspNetCore.Mvc;
using LDNK.Models;

namespace LDNK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductRepository.GetAll();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
