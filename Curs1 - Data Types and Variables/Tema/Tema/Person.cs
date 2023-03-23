using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstN, string lastN)
        {
            firstName = firstN;
            lastName = lastN;
        }

        public void displayName()
        {
            Console.WriteLine("Person's fullname : {0}", firstName + " " + lastName);
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
}
