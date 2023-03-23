namespace Tema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pers1 = new Person("Sebastian", "Paval");
            Person pers2 = new Person("Dragos", "Gherasim");

            pers1.displayName();
            pers2.displayName();

            string[] arrFirstNames = new string[] { pers1.FirstName, pers2.FirstName };

            Array.Sort(arrFirstNames, (string str1, string str2) => str1.CompareTo(str2));                                                 

            foreach(string firstName in arrFirstNames)
            {
                Console.WriteLine(firstName);
            }

            /* List<Person> persList = new List<Person>()
             {
                 pers1, pers2
             };

             persList.Sort((Person pers1, Person pers2) =>
                     pers1.FirstName.CompareTo(pers2.FirstName));

             persList.ForEach((Person pers) =>
                     pers.displayName());  */
        }
    }
}