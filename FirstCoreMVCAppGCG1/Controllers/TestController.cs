using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCAppGCG1.Controllers
{
    public class TestController : Controller
    {
        public string Welcome()
        {
            return "Welcome to my First ASP.NET Core MVC Application";
        }
        public IActionResult WelcomeX(string name)
        {
            ViewBag.msg = name + ", " + "Welcome to my First ASP.NET Core MVC Application";
            return View();
        }
        public IActionResult Max(int x, int y)
        {
            ViewBag.maxVal = Math.Max(x,y);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
