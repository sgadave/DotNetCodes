namespace CRUD;
using BOL;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
public static class CrudOperations
{
    static string fileName = @"D:\IACSD PG-DAC Roll No. - 29,60\Assignments\DotNet\Swapnil\DotNet\PayrollManagement\employees.json";
    static string jsonString = File.ReadAllText(fileName);
    public static void Insert(Employee employee)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        jsonEmployees.Add(employee);
        var employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
        File.WriteAllText(fileName, employeesJson);
    }

    public static void Update(int empid)
    {
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        var options = new JsonSerializerOptions { IncludeFields = true };
        Console.WriteLine("Select Attribute to be Updated\n"
                               + "1. Empid\n" + "2. Ename\n" + "3. Basic Sal\n" + "4. Designation\n");
        int AttrChoice = Convert.ToInt32(Console.ReadLine());
        foreach (Employee emp in jsonEmployees)
        {
            if (emp.EmpId == empid)
            {
                Console.WriteLine("Enter Value");
                switch (AttrChoice)
                {
                    case 1:
                        emp.EmpId = Convert.ToInt32(Console.ReadLine()); ;
                        break;
                    case 2:
                        emp.Ename = Console.ReadLine();
                        break;
                    case 3:
                        emp.BasicSalary = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        emp.Designation = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Error Retry");
                        break;
                }
            }
        }
        var employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
        File.WriteAllText(fileName, employeesJson);
    }

    public static void Delete(int empid)
    {
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        var options = new JsonSerializerOptions { IncludeFields = true };

        for (int i = 0; i < jsonEmployees.Count(); i++)
        {
            if (jsonEmployees[i].EmpId == empid)
            {
                Console.WriteLine("Hello");
                jsonEmployees.RemoveAt(i);
            }
        }
        var employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
        File.WriteAllText(fileName, employeesJson);
    }
    public static void GetById(int empid)
    {
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        var options = new JsonSerializerOptions { IncludeFields = true };
        foreach (Employee emp in jsonEmployees)
        {
            if (emp.EmpId == empid)
            {
                Console.WriteLine("Employee Id=" + emp.EmpId);
                Console.WriteLine("Employee Name=" + emp.Ename);
                Console.WriteLine("Employee Basic Salary=" + emp.BasicSalary);
                Console.WriteLine("Employee Designation=" + emp.Designation);
            }
        }
    }

    public static void GetAllElements()
    {
        List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        jsonString = File.ReadAllText(fileName);
        jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        foreach (Employee emp in jsonEmployees)
        {

            Console.WriteLine("Employee Id=" + emp.EmpId);
            Console.WriteLine("Employee Name=" + emp.Ename);
            Console.WriteLine("Employee Basic Salary=" + emp.BasicSalary);
            Console.WriteLine("Employee Designation=" + emp.Designation);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
