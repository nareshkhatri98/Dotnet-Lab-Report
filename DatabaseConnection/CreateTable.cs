using System;
using System.Data.SqlClient;
using System.Data;


namespace DatabaseConnection
{
    internal class CreateTable
    {
        public void TableCreate()
        {
            string cs = "Data Source =LAPTOP-8KI500RH\\SQLEXPRESS;Initial Catalog = db_swsc; Integrated Security = true;";
          
            try
            {
                
                SqlConnection sc = new SqlConnection(cs);

                if (sc.State == ConnectionState.Open)
                {
                    Console.WriteLine("server connected");
                }
             
                sc.Open();
                string tblquery = "create table tbl_reg(id int primary key, " + " username varchar(50)," + " password varchar(50)," + " repassword varchar(50)," + " gender varchar(50)," + "  course varchar(50), " + " country varchar(50))";
                SqlCommand cmd = new SqlCommand(tblquery, sc);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("table created");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
