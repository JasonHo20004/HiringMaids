using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employer : Person
    {
        //private string[] Requirements { get; set; }
        //private float SalaryOffer { get; set; }
        //private float Bonus { get; set; }
        //private DomesticHelper[] HireHistory { get; set; }
        //private RatingHistory RatingHistory { get; set; }
        //private Contract Contract { get; set; }
        
        // Attributes
       private List<string> requirements;
       private float salaryOffer;
       private float bonus;
       private List<DomesticHelper> hireHistory;
       private List<Rating> ratingHistory;
       private List<Contract> listContract;
       private ByApp app;
        // Constructor
        public Employer(string name, string phoneNumber, string address, DateTime dob, ByApp app) : base(name, phoneNumber, address, dob)
        {
            this.app = app;
        }
        public Employer() { }
        // Methods

    }
}
