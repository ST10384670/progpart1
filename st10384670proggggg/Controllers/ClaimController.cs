using st10384670proggggg.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace st10384670proggggg.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            var claim = new List<Models.Claim>();
            return View(claim);
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
