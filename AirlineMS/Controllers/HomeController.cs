using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AirlineMS.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AirlineMS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
[HttpGet]
    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(Ticket ticket)
    {
        if (ticket.ReturnDate < ticket.DepartureDate)
        {
            ModelState.AddModelError("ReturnDate","Please,enter correctly.ReturnDate has to be greater than DepartureDate.");
        }
        
        
        if (!ModelState.IsValid)
        {
            return View();
        }
        return Json(ticket);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}