using st10384670proggggg.Models;
using Microsoft.AspNetCore.Mvc;

namespace st10384670proggggg.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            var lecturer = new List<Models.Lecturer>();     
            return View(lecturer);
        }

        public IActionResult Create
     ()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
