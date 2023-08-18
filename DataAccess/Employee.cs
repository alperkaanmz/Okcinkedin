using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Employee
    {
        public Employee(string username, string university)
        {
            Username = username;
            University = university;
            ProgrammingLanguages = new List<string>();
        }

        public string Username { get; set; }
        public string University { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
    }
}
