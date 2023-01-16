using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;
using BOL;
using BLL;
using System.Collections.Generic;

namespace MvcPractice.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<DepartmentController> _logger;

    public DepartmentController(ILogger<DepartmentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Iacsd> deptData = DepartmentManager.GetAllIacsdDept();
        ViewData["DeptData"] = deptData;
        return View();
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
