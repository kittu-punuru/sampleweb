using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ENTER eno");
            int eno =int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER ename");
            string ename = Console.ReadLine();
            Console.WriteLine("enter salary");
            double salary = double.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;database=emp;integrated security=yes");
            con.Open();
            string query = "insert into employee values('" + eno + "','" + ename + "','" + salary + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("record is inserted");
            con.Close();
            Console.ReadLine();
        }
    }
}
