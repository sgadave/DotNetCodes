using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Employee e1 = new Employee { EmpId = 1, Ename = "Swapnil", BasicSalary = 50000, Designation = "Manager" };
Employee e2 = new Employee { EmpId = 2, Ename = "Prathamesh", BasicSalary = 45000, Designation = "QA Engineer" };
Employee e3 = new Employee { EmpId = 3, Ename = "Abhishek", BasicSalary = 60000, Designation = "Tester" };
Employee e4 = new Employee { EmpId = 4, Ename = "Nilesh", BasicSalary = 55000, Designation = "ASE" };
Employee e5 = new Employee { EmpId = 5, Ename = "Nachiket", BasicSalary = 25000, Designation = "HR Manager" };
Employee e6 = new Employee { EmpId = 6, Ename = "Pranav", BasicSalary = 15000, Designation = "Production Engineer" };


List<Employee> employees = new List<Employee>();
employees.Add(e1);
employees.Add(e2);
employees.Add(e3);
employees.Add(e4);
employees.Add(e5);
employees.Add(e6);

try
{
    var options = new JsonSerializerOptions { IncludeFields = true };
    var employeesJson = JsonSerializer.Serialize<List<Employee>>(employees, options);
    string fileName = @"D:\IACSD\DotNet\PayrollManagement\employees.json";

    File.WriteAllText(fileName, employeesJson);
    string jsonString = File.ReadAllText(fileName);
    List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
    Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
    foreach (Employee emp in jsonEmployees)
    {
        Console.WriteLine($"{emp.EmpId} : {emp.Ename}");
    }
}catch(Exception exp){
    Console.WriteLine(exp);

}




