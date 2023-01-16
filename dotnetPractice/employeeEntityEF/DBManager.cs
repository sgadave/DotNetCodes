namespace DAL;

using BOL;
using System.Collections.Generic;

public class DBManager : IDBManager
{
    public List<Employee> GetEmployees()
    {
        using (var context = new CollectionContext())//var or CollectionContext any can be used
        {
            var Employee = from EmpTable in context.Employees select EmpTable;
            return Employee.ToList<Employee>();
        }
    }

    public Employee GetEmployeeById(int id)
    {
        using (var context = new CollectionContext())//var or CollectionContext any can be used
        {
            var Employee = context.Employees?.Find(id);
            return Employee!;
        }
    }

    public void InsertEmployee(Employee emp)
    {
        using (var context = new CollectionContext())//var or CollectionContext any can be used
        {
            context.Employees?.Add(emp);
            context.SaveChanges();
            
        }
    }

    public void DeleteEmplyee(int id)
    {
        using (var context = new CollectionContext())//var or CollectionContext any can be used
        {
            context.Employees?.Remove(context.Employees.Find(id)!);
            context.SaveChanges();
        }
    }

    public void UpdateEmplyee(Employee emp)
    {
        using (var context = new CollectionContext())//var or CollectionContext any can be used
        {
            context.Employees?.Update(emp);
            // var Employee = context.Employees.Find(id);
            context.SaveChanges();
        }
    }
}