using JokiaRegistration.Data;
using JokiaRegistration.Models;
using Microsoft.AspNetCore.Mvc;


public class ExitController : Controller
{
    private readonly AppDbContext _context;

    public ExitController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(StaffEntryExit model)
    {
        if (ModelState.IsValid)
        {


            _context.Add(model);

            await _context.SaveChangesAsync();
            Console.WriteLine($"Saving: StaffId={model.StaffId}, Type={model.Type}, Time={DateTime.Now}");
            return RedirectToAction("Confirmation");
        }
        return View(model);
    }
}