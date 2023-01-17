namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;


public class IacsdManager
{
    public static List<Iacsd> GetIacsdCourses(){
        List<Iacsd> iacsdData = DBManager.GetAllCourses();
        return iacsdData;
    }
    
}
