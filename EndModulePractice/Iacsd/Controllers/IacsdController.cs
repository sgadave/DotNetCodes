using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Iacsd.Models;
using BLL;
using BOL;

namespace Iacsd.Controllers;

public class IacsdController : Controller
{
    private readonly ILogger<IacsdController> _logger;

    public IacsdController(ILogger<IacsdController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["IacsdCourses"]=IacsdManager.GetIacsdCourses();
        return View();
    }

    public IActionResult StudentCourse(int id)
    {
        List<BOL.Iacsd> iacsdCourse =IacsdManager.GetIacsdCourses();
        foreach(BOL.Iacsd course in iacsdCourse){
            if(course.CourseId == id){
                ViewData["StudentByCourse"]=StudentManager.GetIacsdStudentByCourse(course);
            }
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
