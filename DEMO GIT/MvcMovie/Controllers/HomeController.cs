using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(String fullname, string address)
    { string strOutput= "xin chào " + fullname+"đếntừ"+address;
    ViewBag.mesage= strOutput;
    return View();
    }

    
}
