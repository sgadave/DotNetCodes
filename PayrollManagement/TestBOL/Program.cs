using BOL;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Welcome to Payroll Management System");
int choice;
Boolean flag = true;
var options = new JsonSerializerOptions { IncludeFields = true };
string fileName = @"D:\IACSD\DotNet\PayrollManagement\employees.json";
do
{
    Console.WriteLine(
        "0. Exit\n"
       + "1. Add New Employee\n"
       + "2. Update Employee Details\n"
       + "3. Delete Employee Details\n"
       + "4. Get Employee By Id\n"
       + "5. Get All Employees\n"
       + "Enter the Choice"
    );
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choice is:--"+choice);
    switch (choice)
    {
        case 0:
            flag = false;
            break;
        case 1:
            Console.WriteLine("Enter EmpId, Ename, Basic Salary, Designation");
            int empid=Convert.ToInt32(Console.ReadLine());
            string ename=Console.ReadLine();
            double basicSal=Convert.ToInt32(Console.ReadLine());
            string desg = Console.ReadLine();
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            Employee employee = new Employee(empid, ename, basicSal,desg);
            jsonEmployees.Add(employee);
            var employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
            File.WriteAllText(fileName, employeesJson);
            break;
        case 2:
            Console.WriteLine("Enter Emp Id");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Attribute to be Updated\n"
                               + "1. Empid\n" + "2. Ename\n" + "3. Basic Sal\n" + "4. Designation\n");
            int AttrChoice =Convert.ToInt32(Console.ReadLine());
             jsonString = File.ReadAllText(fileName);
             jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            foreach (Employee emp in jsonEmployees)
            {
                if (emp.EmpId == empid)
                {
                    Console.WriteLine("Enter Value");
                    switch (AttrChoice)
                    {
                        case 1:
                            emp.EmpId =Convert.ToInt32(Console.ReadLine());;
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
            employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
            File.WriteAllText(fileName, employeesJson);
            break;
        case 3:
            Console.WriteLine("Enter Emp Id");
            empid =Convert.ToInt32(Console.ReadLine());
            jsonString = File.ReadAllText(fileName);
            int index=0;
            jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            
            for (int i=0;i<jsonEmployees.Count();i++)
            {
                if (jsonEmployees[i].EmpId == empid)
                {
                    Console.WriteLine("Hello");
                    jsonEmployees.RemoveAt(i);
                }
            }
            employeesJson = JsonSerializer.Serialize(jsonEmployees, options);
            File.WriteAllText(fileName, employeesJson);
            break;
        case 4:
            Console.WriteLine("Enter Emp Id");
            empid = Convert.ToInt32(Console.ReadLine());
            jsonString = File.ReadAllText(fileName);
            jsonEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
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
            break;
        case 5:
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
            break;
        default:
            Console.WriteLine("Enter Correct Choice");
            break;
    }
} while (flag);