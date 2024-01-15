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

    public IActionResult Edit(int? pageIndex, string sortBy)
    {
        if (!pageIndex.HasValue)
            pageIndex = 555;
        if (String.IsNullOrWhiteSpace(sortBy))
            sortBy = "DANIKA TEST PAGE FOR SORTBY BEING NULL OR WHITE SPACE";
        return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
    }

    public ActionResult ByStatus(int age, string status)
    {
        
        return Content("The current members age is " + age + " and they are " + status);
    }
}