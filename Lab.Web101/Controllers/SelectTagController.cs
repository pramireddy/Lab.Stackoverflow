using Lab.Web101.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Web101.Controllers
{
    public class SelectTagController : Controller
    {
        public IActionResult Index()
        {
            //var model = new CountryViewModel
            //{
            //    Country = "CA"
            //};
            var model = new CountryViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CountryViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    var msg = model.Country + " selected";
            //    return RedirectToAction("IndexSuccess", new { message = msg });
            //}

            // If we got this far, something failed; redisplay form.
            return View(model);
        }
    }
}