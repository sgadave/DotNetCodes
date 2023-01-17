namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBManager
{
    public static string conCredential = @"server=localhost; user=Swapnil; password=Swapnil@99; port=3306; database=IacsdDb";
    public static List<Iacsd> GetAllCourses(){
        List<Iacsd> iacsdData= new List<Iacsd>();

        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Select * from IacsdTable";
        
        try{
            mySqlCon.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["CourseId"].ToString()!);
                string course = reader["CourseName"].ToString()!;
                string bldg = reader["CourseBldg"].ToString()!;

                Iacsd iacsd = new Iacsd(){CourseId=id,CourseName=course,CourseBldg=bldg};
                iacsdData.Add(iacsd);
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }


        return iacsdData;
    }

    public static List<Student> GetAllStudents(){
        List<Student> studentData= new List<Student>();

        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Select * from StudentsTable";
        
        try{
            mySqlCon.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["Id"].ToString()!);
                string name = reader["Name"].ToString()!;
                string course = reader["Course"].ToString()!;
                string address = reader["Address"].ToString()!;

                Student iacsd = new Student(){Id=id,Name=name,Address=address,Course=course};
                studentData.Add(iacsd);
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }


        return studentData;
    }

    public static List<Student> GetStudentsByCourse(Iacsd iacsdCourse){
        List<Student> studentData= new List<Student>();

        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Select * from StudentsTable where course = '"+iacsdCourse.CourseName+"'";
        
        try{
            mySqlCon.Open();
            MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["Id"].ToString()!);
                string name = reader["Name"].ToString()!;
                string course = reader["Course"].ToString()!;
                string address = reader["Address"].ToString()!;

                Student iacsd = new Student(){Id=id,Name=name,Address=address,Course=course};
                studentData.Add(iacsd);
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }


        return studentData;
    }

    public static void InsertStudent(Student student){
        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Insert into StudentsTable values ("+student.Id+",'"+student.Name+"','"+student.Course+"','"+student.Address+"')";
        MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
        try{
            mySqlCon.Open();
            sqlCommand.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }
    }

    public static void UpdateStudent(string column, int id, string value){
        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Update StudentsTable Set "+ column + "='"+value+"' Where id = " + id;
        MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
        try{
            mySqlCon.Open();
            sqlCommand.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }
    }

    public static void DeleteStudent(int id){
        MySqlConnection mySqlCon = new MySqlConnection();
        mySqlCon.ConnectionString = conCredential;
        string query = "Delete from StudentsTable Where id = " + id;
        MySqlCommand sqlCommand = new MySqlCommand(query,mySqlCon);
        try{
            mySqlCon.Open();
            sqlCommand.ExecuteNonQuery();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            mySqlCon.Close();
        }
    }

}
