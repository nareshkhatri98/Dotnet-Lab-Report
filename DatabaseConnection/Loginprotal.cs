using System;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseConnection
{
    internal class LoginPortal
    {
        public void LoginProtocol()
        {
            try
            {
                string cs = "Data Source=LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog=db_swsc;Integrated Security=true;";

                using (SqlConnection sc = new SqlConnection(cs))
                {
                    if (sc.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Server connected");
                    }
                    sc.Open();
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    string loginQuery = "SELECT * FROM tbl_reg WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(loginQuery, sc))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); 

                        using (SqlDataReader row = cmd.ExecuteReader())
                        {
                            while (row.Read())
                            {
                                Console.WriteLine("Login Successfully....");
                                Console.WriteLine("--------------Your Details--------");
                                Console.WriteLine("ID: " + row["id"]);
                                Console.WriteLine("Username: " + row["username"]);
                                Console.WriteLine("Password: " + row["password"]);
                                Console.WriteLine("Gender: " + row["gender"]);
                                Console.WriteLine("Course: " + row["course"]);
                                Console.WriteLine("Country: " + row["country"]);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
