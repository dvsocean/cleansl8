using cleansl8.Models;
using Microsoft.AspNetCore.Mvc;

namespace cleansl8.Controllers;

public class SchoolsController : Controller
{
    // GET
    public IActionResult Index()
    {
        var slate = new Slate() { Name = "IRC WALK A THEN SOME MORE TO CONFIRM MVC PATTERN", Id = 12 };
        
        // return View(slate);
        // return Content("IRC WALK DANIKA");
        // return new EmptyResult();
        return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
    }

    public IActionResult Edit(int id)
    {
        return Content("IRC WALK EDIT_ID=" + id);
    }
}