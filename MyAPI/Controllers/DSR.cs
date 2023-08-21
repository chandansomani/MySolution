using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers
{
    public class DSR : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRecord() { return View(); }
    }
}
