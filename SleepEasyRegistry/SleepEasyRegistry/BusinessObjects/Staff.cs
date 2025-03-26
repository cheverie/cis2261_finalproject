using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepEasyRegistry.BusinessObjects
{
    public class Staff
    {
        public int EmpId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }

        public Staff(int empId, string lastName, string firstName, string title)
        {
            EmpId = empId;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
        }
    }
}
