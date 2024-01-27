using System;
using System.Data.SqlClient;

namespace Demo
{
     class CRUD
    {
        public static void SelectType()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-260ON05E\\SQLEXPRESS;Initial Catalog=Office;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "select* from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]+"\t"+dr[1]+"\t"+dr[2]);
                }
            }
           con.Close();

        }
        public static void InsertType()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-260ON05E\\SQLEXPRESS;Initial Catalog=Office;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "insert into employee(empid,ename,deptno) values(7,'Belgin',103)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateType()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-260ON05E\\SQLEXPRESS;Initial Catalog=Office;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "update employee set ename='Pavithra' where empid=7";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void DeleteType()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-260ON05E\\SQLEXPRESS;Initial Catalog=Office;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "delete from employee where empid=7";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
