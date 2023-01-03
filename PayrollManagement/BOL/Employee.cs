namespace BOL;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Employee
{
    [Required(ErrorMessage ="Employee Id must be definer")]
    public int EmpId{get;set;}
    [Required(ErrorMessage ="Employee name must be defined")]
    public string? Ename{get;set;}
    [Required(ErrorMessage ="Basic Salary Must Be defined")]
    public double BasicSalary{get;set;}
    [Required(ErrorMessage ="Designation must be defined")]
    public string? Designation{get;set;}

    public Employee():this(1,"Swapnil",50000,"Manager"){

    }

    public Employee(int empid,string ename,double basicSalary, string designation){
        this.BasicSalary=basicSalary;
        this.Designation=designation;
        this.EmpId=empid;
        this.Ename=ename;
    }

}
