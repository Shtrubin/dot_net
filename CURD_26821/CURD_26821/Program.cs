using System;
using System.Data;
using System.Data.SqlClient;

namespace CURD_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Enter Option");
            Console.WriteLine("1 For Insert Student");
            Console.WriteLine("2 For Update Student");
            Console.WriteLine("3 For Delete Student");
            Console.WriteLine("4 For Fetch All Student");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    Console.Write("Enter Gender: ");
                    string gender = Console.ReadLine();
                    st.InsertStudent(name, address, gender);
                    Console.WriteLine("Record Inserted");
                    break;
                case "2":
                    Console.Write("Enter Id To Update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string uname = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    string uaddress = Console.ReadLine();
                    Console.Write("Enter Gender: ");
                    string ugender = Console.ReadLine();
                    st.UpdateStudent(uname, uaddress, ugender, id);
                    Console.WriteLine("Record Updated");
                    break;
                case "3":
                    Console.Write("Enter Id To Delete: ");
                    int did = Convert.ToInt32(Console.ReadLine());
                    st.DeleteStudent(did);
                    Console.WriteLine("Record Deleted");
                    break;
                case "4":
                    DataTable dt = st.DisplayStudentData();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Console.WriteLine("Name: {0} Address: {1} Gender: {2}",
                            dt.Rows[i]["Name"], dt.Rows[i]["Address"], dt.Rows[i]["Gender"]);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }
    }

    public class Student
    {
        private string connectionString = "Data Source=(localdb)\\MSSqlLocalDB;Database=SamriddhiDB;Integrated Security=true";

        public void InsertStudent(string name, string address, string gender)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO tblStudent (Name, Address, Gender) VALUES (@name, @address, @gender)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(string name, string address, string gender, int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "UPDATE tblStudent SET Name = @name, Address = @address, Gender = @gender WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM tblStudent WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable DisplayStudentData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM tblStudent";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
