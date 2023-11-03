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
        List<Contract> listContracts = new List<Contract>();
        float salaryOffer;
        string id;
        string maidID;
        char workMode; // Thêm thuộc tính hình thức làm việc

        internal List<Contract> ListContracts { get => listContracts; set => listContracts = value; }



        // Constructor
        public DomesticHelper(string id, string name, string phoneNumber, string address, DateTime dob, float salaryOffer, List<string> skills, char workMode, string maidID) : base(id, name, phoneNumber, address, dob)
        {
            this.salaryOffer = salaryOffer;
            this.skills = skills;
            this.id = id;
            this.workMode = workMode; // Thiết lập giá trị cho thuộc tính hình thức làm việc
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

        public override void printInforInColumn()
        {
            Console.WriteLine("* Maid's ID: "+this.maidID);
            base.printInforInColumn();
        }
        public override string toString()
        {
            string id = "Maid's ID: " + this.maidID + "\t";
            string info = base.toString();
            info += $"Salary offer: {salaryOffer} \t";
            info += $"Skills: " + string.Join(", ", skills) + "\t";
            if (this.workMode == 'F')
                info += $"Work mode: Full-time" + "\n"; //Hình thức làm việc.
            else info += $"Work mode: Part-time" + "\n";
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

        public char GetWorkMode()
        {
            return this.workMode;
        }
    }

}