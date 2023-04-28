using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void Display()
		{
			Console.WriteLine($"Student : {name}");
		}
	}
}
