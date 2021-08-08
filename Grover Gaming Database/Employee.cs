using System;

namespace Grover_Gaming_Database
{
    public class Employee
    {
        public String jobTitle { get; set; }
        public String name { get; set; }
        public Employee(string jobTitle, string name)
        {
            this.jobTitle = jobTitle;
            this.name = name;
        }

        public String[] ToArray()
        {
            string[] stringArray = { this.name, this.jobTitle };
            return stringArray;
        }
    }
}
