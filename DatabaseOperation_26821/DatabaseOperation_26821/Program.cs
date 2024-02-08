using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperation_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInsert_Select obj = new StudentInsert_Select();
            for (int i = 0;i<2;i++)
            {
                Console.WriteLine("Student:" + (i + 1));
                Console.Write("Enter Name:");
                string name=Console.ReadLine();
                Console.Write("Enter address:");
                string address = Console.ReadLine();
                Console.Write("enter Gender:");
                string gender = Console.ReadLine(); 
                obj.Insert(name, address, gender);
                Console.WriteLine("Student Inserted");
            }
            Console.WriteLine("*************************");
            Console.WriteLine("Student Records");
            DataTable dt= obj.GetAllStudent();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", dt.Rows[i]["Name"].ToString(), dt.Rows[i]["Address"].ToString(), dt.Rows[i]["Gender"].ToString());

            }
            Console.WriteLine("Total Student" + dt.Rows.Count);
            Console.ReadLine(); 


        }
    }
    public  class StudentInsert_Select
    {
        public void Insert(string name, string address, string gender)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Database=SamriddhiData; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("insert into tblStudent values (@a,@b,@c)",con);
            cmd.Parameters.AddWithValue("@a", name);
            cmd.Parameters.AddWithValue("@b", address);
            cmd.Parameters.AddWithValue("@c", gender);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();   

        }

        public DataTable GetAllStudent()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Database=SamriddhiData; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select *from tblStudent", con);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

            
        }
    }
}
