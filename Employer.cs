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
        private List<string> requirements = new List<string>();
        private float salaryOffer;
        private float bonus;
        private List<DomesticHelper> hireHistory;
        private List<Rating> ratingHistory;
        private List<Contract> listContract;
        // Constructor
        public Employer(string name, string phoneNumber, string address, DateTime dob) : base(name, phoneNumber, address, dob)
        {
        }
        public Employer() { }
        // Methods
        public void setSalaryOffer(float x)
        {
            this.salaryOffer = x;
        }
        public float getSalaryOffer()
        {
            return this.salaryOffer;
        }
        public void addRequirement(List<string> T)
        {
            this.requirements.Clear();
            this.requirements.AddRange(T);
        }

        public List<string> getListRequirements()
        {
            return this.requirements;
        }
        public override string toString()
        {
            string info = base.toString();
            return info;
        }
    }
}
