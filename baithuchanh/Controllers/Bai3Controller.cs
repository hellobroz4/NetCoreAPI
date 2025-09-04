using Microsoft.AspNetCore.Mvc;

namespace baithuchanh.Controllers.baithuchanh
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
