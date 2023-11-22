using Microsoft.AspNetCore.Mvc;

namespace TourProject.ViewComponents.Default
{
    public class _Slider : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
