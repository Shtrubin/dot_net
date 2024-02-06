using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create student class with propertirs for id, name, gender and address
//Then create a List<Student> to store instances of this class
//the program adds 10 students to the list prints the list
//and then searches for a student bu their addesss using the FindStudentByAddress function.
//finally it prints the result of the search

namespace find_std_26821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>();
            st.Add(new Student() {Id=1, Name="Ram", Address="ktm", Gender="Male" });
            st.Add(new Student() { Id = 1, Name = "Ram", Address = "ktm", Gender = "Male" });
            st.Add(new Student() { Id = 1, Name = "Sam", Address = "ltm", Gender = "Male" });
            st.Add(new Student() { Id = 1, Name = "Tam", Address = "ktm", Gender = "female" });
            st.Add(new Student() { Id = 1, Name = "Uam", Address = "mtm", Gender = "female" });
            st.Add(new Student() { Id = 1, Name = "Vam", Address = "ktm", Gender = "female" });
            st.Add(new Student() { Id = 1, Name = "Wam", Address = "ktm", Gender = "Male" });
            st.Add(new Student() { Id = 1, Name = "Xam", Address = "ntm", Gender = "Male" });
            st.Add(new Student() { Id = 1, Name = "Yam", Address = "ktm", Gender = "Male" });
            st.Add(new Student() { Id = 1, Name = "Zam", Address = "otm", Gender = "Male" });
            Console.WriteLine("****************************List fo students**********************8");
            foreach (var item in st)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", item.Name, item.Address, item.Gender);
            }

            Console.WriteLine();
            Console.WriteLine("*********Student with address Ktm**************");
            List<Student> filterStudent = FindStudentByAddress(st, "ktm");
            foreach (var item in filterStudent)
            {
                Console.WriteLine("Name:{0} Address:{1} Gender:{2}", item.Name, item.Address, item.Gender);
            }
            Console.ReadLine();



        }
        public static List<Student> FindStudentByAddress(List<Student> students, string searchAddress)
        {
            List<Student> filterStudent = new List<Student>();
            foreach (Student item in students) 
            { 
            if (item.Address == searchAddress)
                {
                    filterStudent.Add(item);
                }   
            }
            return filterStudent;
        }
    }

  public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public String Gender { get; set; }

    }
}
