using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Iacsd.Models;
using BLL;
using BOL;

namespace Iacsd.Controllers;

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
        Student student = new Student(){Id=id,Name=name,Course=course,Address=address};
        StudentManager.InsertStudentData(student);   
        return Redirect("/Home/Index");
    }

    public IActionResult UpdateData()
    {
        return View();
    }

    public IActionResult UpdateStudentData(string column,int id,string value){
        StudentManager.UpdateStudentData(column,id,value);
        return Redirect("/Home/Index");
    }

    public IActionResult DeleteStudent()
    {
        return View();
    }

    public IActionResult DeleteStudentData(int id){
        StudentManager.DeleteStudentData(id);
        return Redirect("/Home/Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
