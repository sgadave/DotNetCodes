using DAL;
using BOL;

Console.WriteLine("WELCOME TO SG PVT. LTD.");
DBManager dBMng = new DBManager();
bool flag = true;
while (flag)
{
    Console.WriteLine("0. Exit");
    Console.WriteLine("1. Insert Employee");
    Console.WriteLine("2. Delete Employee");
    Console.WriteLine("3. Update Employee");
    Console.WriteLine("4. Search Employee");
    Console.WriteLine("5. Display All Employees");
    int choice = int.Parse(Console.ReadLine()!);
    switch (choice)
    {
        case 0:
            flag=false;
            break;
        case 1:
            Console.WriteLine("Enter Employee ID");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Employee Salary");
            double sal = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter Employee Experience");
            int exp = int.Parse(Console.ReadLine()!);
            Employee emp = new Employee() { Id = id, Salary = sal, Name = name, Experience = exp };
            dBMng.InsertEmployee(emp);
            break;
        case 2:
            Console.WriteLine("Enter Employee ID");
            id = int.Parse(Console.ReadLine()!);
            dBMng.DeleteEmplyee(id);
            break;
        case 3:
            Console.WriteLine("Enter Employee ID");
            id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Employee Salary");
            sal = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine()!;
            Console.WriteLine("Enter Employee Experience");
            exp = int.Parse(Console.ReadLine()!);
            emp = new Employee() { Id = id, Salary = sal, Name = name, Experience = exp };
            dBMng.UpdateEmplyee(emp);
            break;
        case 4:
            Console.WriteLine("Enter Employee ID");
            id = int.Parse(Console.ReadLine()!);
            emp = dBMng.GetEmployeeById(id);
            Console.WriteLine("Name : {0} , Id : {1}, Salary : {2}, Experience : {3}", emp.Name, emp.Id, emp.Salary, emp.Experience);
            break;
        case 5:
            Console.WriteLine("ALL Employes Are listed Below");
            List<Employee> emps = dBMng.GetEmployees();
            foreach (Employee employee in emps)
            {
                Console.WriteLine("Name : {0} , Id : {1}, Salary : {2}, Experience : {3}", employee.Name, employee.Id, employee.Salary, employee.Experience);
            }
            break;
    }
}

