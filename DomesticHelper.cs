using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DomesticHelper : Person
    {
        // Attributes
        List<WorkHistory> workHistory;
        List<Rating> ratingHistory;
        List<string> skills;
        public List<Contract> ListContracts;
        float salaryOffer;
        string id;
        string maidID;
        string workMode; // Thêm thuộc tính hình thức làm việc

        // Constructor
        public DomesticHelper(string id,string name, string phoneNumber, string address, DateTime dob, float salaryOffer, List<string> skills, string workMode,string maidID) : base(id,name, phoneNumber, address, dob)
        {
            this.salaryOffer = salaryOffer;
            this.skills = skills;
            this.id = id;
            this.workMode = workMode; // Thiết lập giá trị cho thuộc tính hình thức làm việc
            this.maidID=maidID;
            this.ListContracts = new List<Contract>();  
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
            info += $"Skills: " + string.Join(", ", skills) + "\t";
            info += $"Work mode: {workMode}"+"\n"; //Hình thức làm việc.
            return id + info;
        }
        public bool HasSkill(string skill)
        {
            return skills.Contains(skill);
        }
        public string GetLocation()
        {
            return this.address;
        }

        public string GetWorkMode()
        {
            return this.workMode;
        }
    }

}
