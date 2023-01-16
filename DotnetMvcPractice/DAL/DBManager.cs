namespace DAL;
using System.Collections.Generic;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conCredential = @"server=localhost;
                                        user=root;
                                        port=3307;
                                        password=root123;
                                        database=iacsdcdac";//newly created database 

    public static List<Iacsd> GetIacsdData()
    {
        List<Iacsd> dataList = new List<Iacsd>();//create list to store data
        MySqlConnection mySqlCon = new MySqlConnection();//created connection object

        mySqlCon.ConnectionString = conCredential;//passed connection credential to the connection object
        try//writing try catch block to avoid exceptions
        {
            mySqlCon.Open();//started the connection 
            MySqlCommand sqlCommand = new MySqlCommand();//created a command object to pass query string
            sqlCommand.Connection=mySqlCon;
            sqlCommand.CommandText = "Select * from IacsdTable";//passed query string to the command object
            MySqlDataReader reader = sqlCommand.ExecuteReader();//created a reader similar to scanner to read database data 

            while (reader.Read())//created while loop to read data row wise until End
            {
                //Getting each data from data base to its particular data member, Also the names used in reader brackets should be same as that of columns names in database table
                int id = int.Parse(reader["Id"].ToString()!);//used parse to coinvert string to int
                string dept = reader["Dept"].ToString()!;//set dept column data to a variable
                string bldg = reader["Bldg"].ToString()!;//set bldg column data to a variable
                                                         //Creating the object using default constructor and adding data to it
                Iacsd iacsd = new Iacsd() { Id = id, Dept = dept, Bulding = bldg };//create object of iacsd using the data obtained from database
                dataList.Add(iacsd);//Add the object created to the datalist of type List<Iacsd>;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            mySqlCon.Close();
        }
        return dataList;
    }
    // -----------------------------------Method GetIacsdData Ended here-----------------------
    // -----------------------------------Method GetStudentData Started here-----------------------
    public static List<Student> GetStudentData()
    {
        List<Student> dataList = new List<Student>();//create list to store data
        MySqlConnection mySqlCon = new MySqlConnection();//created connection object

        mySqlCon.ConnectionString = conCredential;//passed connection credential to the connection object
        try//writing try catch block to avoid exceptions
        {
            mySqlCon.Open();//started the connection 
            MySqlCommand sqlCommand = new MySqlCommand();//created a command object to pass query string
            sqlCommand.Connection=mySqlCon;
            sqlCommand.CommandText = "Select * from StudentTable";//passed query string to the command object
            MySqlDataReader reader = sqlCommand.ExecuteReader();//created a reader similar to scanner to read database data 

            while (reader.Read())//created while loop to read data row wise until End
            {
                //Getting each data from data base to its particular data member, Also the names used in reader brackets should be same as that of columns names in database table
                int id = int.Parse(reader["Id"].ToString()!);//used parse to coinvert string to int
                string name = reader["Name"].ToString()!;//set Name column data to a variable
                string course = reader["Course"].ToString()!;//set Course column data to a variable
                string address = reader["Address"].ToString()!;//set Address column data to a variable
                                                               //Creating the object using default constructor and adding data to it
                Student student = new Student() { Id = id, Name = name, Course = course, Address = address };//create object of iacsd using the data obtained from database
                dataList.Add(student);//Add the object created to the datalist of type List<Iacsd>;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            mySqlCon.Close();
        }
        return dataList;
    }

    // ----------------------------------GetStudentData Ended Here--------------------------------- 
    // ----------------------------------InsertStudentData Start Here--------------------------------- 
    public static void InsertStudentData(Student student)
    {
        MySqlConnection mysqlCon = new MySqlConnection();
        mysqlCon.ConnectionString = conCredential;
        try
        {
            mysqlCon.Open();

            string query = "Insert into StudentsTable values(" + student.Id + ",'" + student.Name + "','" + student.Course + "','" + student.Address + "')";
            MySqlCommand sqlCommand = new MySqlCommand(query,mysqlCon);
            sqlCommand.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            mysqlCon.Close();
        }
    }

    public static void InsertIacsdData(Iacsd iacsd)
    {
        MySqlConnection mysqlCon = new MySqlConnection();
        mysqlCon.ConnectionString = conCredential;
        try
        {
            mysqlCon.Open();
            string query = "Insert into IacsdTable values(" + iacsd.Id + "," + iacsd.Dept + "," + iacsd.Bulding + ")";
            MySqlCommand sqlCommand = new MySqlCommand(query,mysqlCon);
            sqlCommand.ExecuteNonQuery();
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            mysqlCon.Close();
        }
    }


}