namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class DepartmentManager{
    public static List<Iacsd> GetAllIacsdDept(){
        List<Iacsd> deptData = DBManager.GetIacsdData();
        return deptData;
    } 
}