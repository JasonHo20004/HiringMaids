using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employer : Person
    {
        // Attributes
        private List<string> requirements = new List<string>();
        private float salaryOffer;
        private string bonusRegime;
        public List<DomesticHelper> hireHistory;
        public List<Rating> ratingHistory;
        public List<Contract> ListContract;
        public Broker brokers;
        // Constructor
        public Employer(string id, string name, string phoneNumber, string address, DateTime dob) : base(id, name, phoneNumber, address, dob)
        {
            ListContract = new List<Contract>();
        }

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
