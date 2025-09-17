using st10384670proggggg.Models;
using Microsoft.AspNetCore.Mvc;

namespace st10384670proggggg.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new List<Models.User>(); 
            return View(user);
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
