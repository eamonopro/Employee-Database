using System;

namespace Grover_Gaming_Database
{
   
    public class Employee
    {
        

        public int Id { get; set; }
        public String jobTitle { get; set; }
        public String name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="jobTitle">Employee job title</param>
        public Employee(string name, string jobTitle)
        {
            this.jobTitle = jobTitle;
            this.name = name;
        }
        
      

     
        // returns a readable version of the employee, for use in message boxes
        public String toString()
        {
            return name + ", " + jobTitle;
        }
    }
}
