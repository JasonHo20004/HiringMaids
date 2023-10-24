using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DomesticHelper : Person
    {   
        //private string[] Skills { get; set; }
        //private WorkHistory[] WorkHistory { get; set; }
        //private RatingHistory RatingHistory { get; set; }
        //private Contract Contract { get; set; }

        // Attributes
        List<WorkHistory> workHistory;
        List<Rating> ratingHistory;
        List<string> skills;
        List<Contract> contracts;
        public DomesticHelper(string name, string phoneNumber, string address, DateTime dob) : base(name, phoneNumber, address, dob)
        {
        }




    }
}
