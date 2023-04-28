using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Course
    {
        private List<Student> studentList;

        public List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        private Teacher teacher;
        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Course(List<Student> studentList, Teacher teacher, string name)
        {
            this.studentList = studentList;
            this.teacher = teacher;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Course : {name}, Teacher : {teacher.Name}, Students : ");
            studentList.ForEach(student => Console.WriteLine(student.Name));
        }
    }
}
