using System.ComponentModel.Design;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student() { Name = "Dragos" };

            List<Student> stdList1 = new List<Student>() { std,
                                                           new Student() { Name = "Sebi"},
                                                           new Student() { Name = "Octavian"} };

            List<Student> stdList2 = new List<Student>() {  std,
                                                            new Student() { Name = "Sebi"} };

            Teacher teacher = new Teacher() { Name = "Radu" };

            List<Course> courses = new List<Course>() { new Course(stdList1, teacher, "OOP"),
                                                        new Course(stdList2, teacher, "OOPv2")};

            courses.Where(course => course.Name == "OOP").ToList().ForEach(course => course.StudentList.ForEach(student => student.Display()));
            Console.WriteLine();
            courses.Where(course => course.Name == "OOPv2").ToList().ForEach(course => course.StudentList.ForEach(student => student.Display()));

            Console.WriteLine();
            courses.Where(course => course.StudentList.Contains(std)).ToList().ForEach(course => Console.Write(course.Name + ' '));
        }
    }
}