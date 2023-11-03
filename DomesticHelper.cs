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
        float salaryOffer;
        string id;
        string maidID;
        // Constructor
        public DomesticHelper(string id, string name, string phoneNumber, string address, DateTime dob, float salaryOffer, List<string> skills, string maidID) : base(id, name, phoneNumber, address, dob)
        {
            this.salaryOffer = salaryOffer;
            this.skills = skills;
            this.maidID = maidID;
        }
        // Methods
        public float getSalaryOffer()
        {
            return salaryOffer;
        }
        public string getMaidID()
        {
            return this.maidID;
        }
        public override string toString()
        {
            string id = "Maid's ID: " + this.maidID + "\t";
            string info = base.toString();
            info += $"Salary offer: {salaryOffer} \t";
            info += $"Skills: " + string.Join(", ", skills) + "\n";
            return id + info;
        }

        public bool HasSkill(string skill)
        {
            return skills.Contains(skill);
        }
    }
}
