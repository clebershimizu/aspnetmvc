using Microsoft.AspNetCore.Mvc;

namespace ShimizuConceptMVC.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
