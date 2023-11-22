using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TourProject.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.Destinations = c.Destinations.Count();
            ViewBag.Guides = c.Guides.Count();
            ViewBag.Customers = 31;
            return View();
        }
    }
}
