using Microsoft.AspNetCore.Mvc;
using SampleMVCProject.Models;
using System.Diagnostics;

namespace SampleMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List <Student> st = new List<Student>();
            string name = "Ashwini";
            int id = 1;

            Student ss = new Student();
            ss.name = name;
            ss.id= id;

            st.Add(ss);

            name = "Ramakrishan";
            id = 2;
            Student k= new Student();
            k.name = name;
            k.id= id;

            st.Add(k);

            ViewBag.List = st;
            ViewData["StudentDetails"] = st;


            return View(st);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
