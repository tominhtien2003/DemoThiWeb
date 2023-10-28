using Microsoft.AspNetCore.Mvc;

namespace DemoThiWeb.Controllers
{
    public class BaiThi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
