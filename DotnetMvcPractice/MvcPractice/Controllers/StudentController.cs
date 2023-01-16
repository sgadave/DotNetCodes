using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;
using BLL;
using BOL;

namespace MvcPractice.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult InsertData(int id, string name, string course, string address)
    {
        Student std = new Student(){Id=id,Name=name,Course=course,Address=address};
        StudentManager.InsertStudentData(std);
        return Redirect("/Home/Index");
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
