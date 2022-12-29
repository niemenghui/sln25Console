using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace prj25aConsoleNF
{    internal class Program25a
    {
        static void Main(string[] args)
        {
            SqlConnection2510();        
            //Thread.Sleep(9000);
            Console.ReadKey();
        }

        static void SqlConnection2510()
        {
            string connetionString;
            SqlConnection con;
            connetionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            con = new SqlConnection(connetionString);
            con.Open();
            Console.WriteLine("Connection open!");
            SqlCommand cmd;
            SqlDataReader dataReader;
            String sql, output = "";
            sql = "select name, salary from Table1";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                output = "" + dataReader.GetValue(0) + dataReader.GetValue(1);
                Console.WriteLine("row:" + output);              
            }            
            con.Close();
        }
    }
}