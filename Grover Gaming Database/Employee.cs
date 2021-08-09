using System;

namespace Grover_Gaming_Database
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public String jobTitle { get; set; }
        public String name { get; set; }
        public Employee(string name, string jobTitle)
        {
            this.jobTitle = jobTitle;
            this.name = name;
        }

        public String[] ToArray()
        {
            string[] stringArray = { this.name, this.jobTitle };
            return stringArray;
        }

        public int CompareTo(object obj)
        {
            return name.CompareTo(obj);
        }

        public String toString()
        {
            return name + ", " + jobTitle;
        }
    }
}
