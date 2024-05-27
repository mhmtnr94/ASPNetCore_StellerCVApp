using Microsoft.AspNetCore.Mvc;

namespace MemoCV.Controllers
{
    public class Admin2Controller : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
