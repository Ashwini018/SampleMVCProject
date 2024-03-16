using Microsoft.AspNetCore.Mvc;

namespace SampleMVCProject.Controllers
{
    public class StudentHome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
