using BOL;

using CRUD;

Console.WriteLine("Welcome to Payroll Management System");
int choice;
Boolean flag = true;

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
    Console.WriteLine("Choice is:--" + choice);
    switch (choice)
    {
        case 0:
            flag = false;
            break;
        case 1:
            Console.WriteLine("Enter EmpId, Ename, Basic Salary, Designation");
            int empid = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            double basicSal = Convert.ToInt32(Console.ReadLine());
            string desg = Console.ReadLine();
            Employee employee = new Employee(empid, ename, basicSal, desg);
            CrudOperations.Insert(employee);
            break;
        case 2:
            Console.WriteLine("Enter Emp Id");
            empid = Convert.ToInt32(Console.ReadLine());
            CrudOperations.Update(empid);
            break;
        case 3:
            Console.WriteLine("Enter Emp Id");
            empid = Convert.ToInt32(Console.ReadLine());
            CrudOperations.Delete(empid);
            break;
        case 4:
            Console.WriteLine("Enter Emp Id");
            empid = Convert.ToInt32(Console.ReadLine());
            CrudOperations.GetById(empid);
            break;
        case 5:
            CrudOperations.GetAllElements();
            break;
        default:
            Console.WriteLine("Enter Correct Choice");
            break;
    }
} while (flag);