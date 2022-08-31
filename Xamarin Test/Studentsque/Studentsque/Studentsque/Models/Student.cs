using System;
namespace Studentsque.Models
{
    public class Student
    {

        public string StudentName
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Course
        {
            get;
            set;
        }
        public string Image
        {
            get;
            set;
        }
        public Student(string name, string gender, int age, string course,string image)
        {
            StudentName = name;
            Gender = gender;
            Age = age;
            Course = course;
            Image = image;
        }

    }
}

