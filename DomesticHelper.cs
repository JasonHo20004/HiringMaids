using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DomesticHelper : Person
    {
        private string[] Skills { get; set; }
        private WorkHistory[] WorkHistory { get; set; }

        public DomesticHelper(string name, string phoneNumber, string address, DateTime dob, string[] skills, WorkHistory[] workHistory) : base(name, phoneNumber, address, dob)
        {
            Skills = skills;
            WorkHistory = workHistory;
        }
    }
}
