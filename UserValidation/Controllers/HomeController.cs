using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserValidation.Models;
using UserDataSerialization;

namespace UserValidation.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(string userId,string password){
        if(SerializerDeserializer.ValidateUser( userId, password)){
                return Redirect("/home/welcome");
        }else{
            return Redirect("/home/registration");
        }

    }

    public IActionResult Registration()
    {
        return View();
    }

    public IActionResult SubmitData(string userId, string password, string fName, string lName, string address, string mobileNo)
    {
        SerializerDeserializer.RegisterUser(userId, password, fName, lName, address, mobileNo);
        return Redirect("/home/index");
    }

    public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
