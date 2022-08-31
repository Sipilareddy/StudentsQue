using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Studentsque.Models;

namespace Studentsque.Services
{
	public class StudentService
	{
        public ObservableCollection<Student> Students { get; set; }

        public StudentService()
        {
            Students = new ObservableCollection<Student>();
            InitializeEmployeeService();
        }

        public void InitializeEmployeeService()
        {

            Students.Add(new Student( "Abhiram", "Male", 25,"B.Tech", "ContactIcon.png"));
            Students.Add(new Student("Sai", "Male", 22, "M.Tech", "ContactIcon.png"));
            Students.Add(new Student("Nancy", "female", 22, "B.Tech", "ContactIcon.png"));
            Students.Add(new Student("Harish", "Male", 26, "B.Tech", "user.svg"));
            Students.Add(new Student("Anitha", "Female", 28, "B.Tech", "ContactIcon.png"));
            Students.Add(new Student("Prasanna", "Female", 21, "M.Tech", "ContactIcon.png"));
            Students.Add(new Student("Abhi", "Male", 25, "B.Tech", "ContactIcon.png"));
            Students.Add(new Student("Uday", "Male", 22, "M.Tech", "ContactIcon.png"));
            Students.Add(new Student("Lakshmi", "female", 22, "B.Tech", "ContactIcon.png"));
            Students.Add(new Student("Lokesh", "Male", 26, "B.Tech", "user.svg"));
        }

        public  ObservableCollection<Student> GetStudentsAsync(string query)
        {
            // Thread.Sleep(2000);
            Students.Clear();
            if (query != string.Empty)
            {
               
                InitializeEmployeeService();
                List<Student> llstEmployees = Students.Where(emp => (emp.StudentName.ToLower().Contains(query.ToLower()))).ToList();

                Students.Clear();
                foreach (Student employee in llstEmployees)
                {
                    Students.Add(employee);
                }

            }
            else
            {
                InitializeEmployeeService();
            }
            return Students;
        }
    }
}

