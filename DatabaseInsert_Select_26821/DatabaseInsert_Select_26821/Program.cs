using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; //MS SQL Server
namespace DatabaseInsert_Select_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st= new Student();
            st.InsertStudent();
            st.DisplayStudent();
            
            Console.ReadLine();

        }
    }
    public class Student
    {
        public void InsertStudent()
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB; Database=SamriddhiDB; Integrated Security=true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("insert into tblStudent values(@name,@address,@gender)", con);
            cmd.Parameters.AddWithValue("@name", "Rubin");
            cmd.Parameters.AddWithValue("@address", "Kathmandu");
            cmd.Parameters.AddWithValue("@gender", "Male");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record Inserted");
        }
        public void DisplayStudent() 
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB; Database = SamriddhiDB; Integrated Security = true";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select *from tblStudent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                Console.WriteLine("Name: {0} Address: {1} Gender:{2}",
                    dt.Rows[i]["Name"], dt.Rows[i]["Address"],dt.Rows[i]["Gender"]);
            }

        }
    }
}
