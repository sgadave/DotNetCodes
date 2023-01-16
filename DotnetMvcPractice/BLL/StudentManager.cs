namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class StudentManager{
    public static List<Student> GetAllStudentData(){
        List<Student> deptData = DBManager.GetStudentData();
        return deptData;
    } 

    public static void InsertStudentData(Student std){
        DBManager.InsertStudentData(std);
    
    }
}