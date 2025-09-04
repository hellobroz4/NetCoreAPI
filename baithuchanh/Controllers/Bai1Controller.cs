using Microsoft.AspNetCore.Mvc;

namespace baithuchanh.Controllers.baithuchanh
{
    public class Bai1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
