using Microsoft.AspNetCore.Mvc;

namespace RoutingCore.Controllers
{
    [Route("{controller}/{action}")]  // Token Level
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int Contact(int ?id)
        { 
            return id ?? 100;
        }
    }
}
