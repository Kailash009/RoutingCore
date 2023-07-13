using Microsoft.AspNetCore.Mvc;

namespace RoutingCore.Controllers
{
    //[Route("{controller}/{action}")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
