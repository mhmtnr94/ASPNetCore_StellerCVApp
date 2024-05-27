using Microsoft.AspNetCore.Mvc;

namespace MemoCV.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
