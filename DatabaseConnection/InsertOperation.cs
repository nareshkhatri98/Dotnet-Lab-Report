using System;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection
{
    internal class InsertOperation
    {

        public void insert()
        {

            // creating connection string;
            string cs = "Data Source =LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog = db_swsc; Integrated Security = true;";
            
            try
            {
                // creatin
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("server connected");
                }
                sc.Open();
                Console.WriteLine("Enter your id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();
                Console.WriteLine("Enter your repasword:");
                string repassword = Console.ReadLine();
                Console.WriteLine("Enter your gender:");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter your course:");
                string course = Console.ReadLine();
                Console.WriteLine("Enter your country:");
                string country = Console.ReadLine();

                //query 
                string insQuery = "insert into tbl_reg values(@id,@username,@password,@repassword,@gender,@course,@country)";
                SqlCommand cmd = new SqlCommand(insQuery, sc);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@repassword", repassword);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@country", country);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Data inserted");
                }
                sc.Close();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
