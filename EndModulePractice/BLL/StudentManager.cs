namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;


public class StudentManager
{
    public static List<Student> GetIacsdStudent(){
        List<Student> iacsdStudentData = DBManager.GetAllStudents();
        return iacsdStudentData;
    }

    public static List<Student> GetIacsdStudentByCourse(Iacsd iacsd){
        List<Student> iacsdStudentData = DBManager.GetStudentsByCourse(iacsd);
        return iacsdStudentData;
    }

    public static void InsertStudentData(Student student){
        DBManager.InsertStudent(student);
    }

    public static void UpdateStudentData(string column, int id, string value){
        DBManager.UpdateStudent(column,id,value);
    }

    public static void DeleteStudentData( int id){
        DBManager.DeleteStudent(id);
    }
}
