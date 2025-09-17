using st10384670proggggg.Models;
using Microsoft.AspNetCore.Mvc;

namespace st10384670proggggg.Controllers
{
    public class DocsController : Controller
    {
        public IActionResult Index()
        {
            var docs = new List<Models.Docs>();
            return View(docs);
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
