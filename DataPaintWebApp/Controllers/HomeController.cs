using Microsoft.AspNetCore.Mvc;

namespace DataPaintWebApp.Controllers
{

    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("Home")]
        public IActionResult Index()
        {
            return PartialView("_Home");
        }
    }
}
