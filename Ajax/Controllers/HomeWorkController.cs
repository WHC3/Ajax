using Microsoft.AspNetCore.Mvc;

namespace Ajax.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
