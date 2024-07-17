

using Microsoft.AspNetCore.Mvc;

namespace ALiUni.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()=>  View();
        public IActionResult About() => View();
        public IActionResult Codes() => View();
        public IActionResult Contact() => View();
        public IActionResult Courses() => View();
        public IActionResult Project() => View();
        public IActionResult Services() => View();


      
     
    }
}