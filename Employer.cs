using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employer : Person
    {
        private string[] Requirements { get; set; }
        private float SalaryOffer { get; set; }
        private float Bonus { get; set; }
        private DomesticHelper[] HireHistory { get; set; }
        private RatingHistory RatingHistory { get; set; }
        private Contract Contract { get; set; }

        public Employer(string name, string phoneNumber, string address, DateTime dob, string[] requirements, float salaryOffer, float bonus, DomesticHelper[] hireHistory, RatingHistory ratingHistory, Contract contract) : base(name, phoneNumber, address, dob)
        {
            Requirements = requirements;
            SalaryOffer = salaryOffer;
            Bonus = bonus;
            HireHistory = hireHistory;
            RatingHistory = ratingHistory;
            Contract = contract;
        }
    }
}
