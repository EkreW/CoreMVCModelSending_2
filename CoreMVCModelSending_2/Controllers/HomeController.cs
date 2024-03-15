using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
