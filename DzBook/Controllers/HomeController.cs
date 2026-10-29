using Microsoft.AspNetCore.Mvc;

namespace DzBook.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult About() => View();
    public IActionResult Contacts() => View();
    public IActionResult Privacy() => View();
}