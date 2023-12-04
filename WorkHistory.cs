using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WorkHistory
    {
        //private string Address { get; set; }
        //private float Completion { get; set; }
        //private float Salary { get; set; }
        //private DateTime StartDate { get; set; }
        //private DateTime EndDate { get; set; }

        //Attributes
        string workLocation;
        float salary;
        DateTime startDate;
        DateTime endDate;
        float completion;
        // Constructors
        public WorkHistory(string workLocation, float salary, DateTime startDate, DateTime endDate, float completion)
        {
            this.workLocation = workLocation;
            this.salary = salary;
            this.startDate = startDate;
            this.endDate = endDate;
            this.completion = completion;
        }
        // Methods
    }
}
