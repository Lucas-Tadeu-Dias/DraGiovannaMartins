using Microsoft.AspNetCore.Mvc;
namespace DraGiovannaMartins.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Privacidade() => View();
}