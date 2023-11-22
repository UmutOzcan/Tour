using Microsoft.AspNetCore.Mvc;

namespace TourProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
