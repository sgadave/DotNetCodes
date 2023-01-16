namespace DAL;
using BOL;
using System.Collections.Generic;

public interface IDBManager{
    public List<Employee> GetEmployees();
    public Employee GetEmployeeById(int id);

    public void InsertEmployee(Employee emp);
    public void DeleteEmplyee(int id);
    public void UpdateEmplyee(Employee emp);
}