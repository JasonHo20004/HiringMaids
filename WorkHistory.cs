using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WorkHistory
    {
        private string Address { get; set; }
        private float Completion { get; set; }
        private float Salary { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        public WorkHistory(string address, float completion, float salary, DateTime startDate, DateTime endDate)
        {
            Address = address;
            Completion = completion;
            Salary = salary;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
