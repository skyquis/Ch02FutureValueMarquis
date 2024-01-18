using Microsoft.AspNetCore.Mvc;
using Ch02FutureValueMarquis.Models;
public class HomeController : Controller
    {
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FV = 0;
        return View();
    }
    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
        ViewBag.FV = 0;
        return View(model);
    }
}
