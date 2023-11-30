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
        string maidID;
        string workMode; // Thêm thuộc tính hình thức làm việc
  
        // Constructor
        public DomesticHelper(string id, string name, string phoneNumber, string address, string dob, float salaryOffer, List<string> skills, string workMode, string maidID) : base(id, name, phoneNumber, address, dob)
        {
            this.salaryOffer = salaryOffer;
            this.skills = skills;
            this.id = id;
            this.workMode = workMode; // Thiết lập giá trị cho thuộc tính hình thức làm việc
            this.maidID = maidID;
            this.ListContracts = new List<Contract>();
            this.ratingHistory = new List<Rating>();
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

     
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string getAddress()
        {
            return this.address;
        }
        public DateTime getDob()
        {
            return this.dob;
        }
        public string getID()
        {
            return this.id;
        }
        public string GetSkills()
        {
            string s = "";
            foreach (string i in this.skills)
            {
                s = s + i;
                s = s + ", ";
            }
            //s= s.TrimEnd(' ');
            //s = s.TrimEnd(',');
            return s;
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
        public void PrintSample()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Name:",-15} | {this.name}");
            Console.WriteLine($"{"ID:",-15} | {this.id}");
            Console.WriteLine($"{"Date of birth:",-15} | {this.dob.ToShortDateString()}");
            Console.WriteLine($"{"Phone number:",-15} | {this.phoneNumber}");
            Console.WriteLine($"{"Address:",-15} | {this.address}");
            Console.WriteLine($"{"Salary:",-15} | {this.salaryOffer}");
            Console.WriteLine($"{"Work-mode:",-15} | {this.workMode}");
        }
        public void DisplayHireHistory()
        {
            foreach (Contract c in this.ListContracts)
            {
                c.CheckContractStatus();
                Employer e = c.GetEmployer();
                e.PrintSample();
                if (c.GetStatus() == false)
                {
                    Console.WriteLine($"{"Status:",-15} | {"The contract has expired"}");
                    Console.WriteLine($"{"Start Date:",-15} | {c.GetStartDate()}");
                    Console.WriteLine($"{"End Date:",-15} | {c.GetEndDate()}");
                }
                else
                {
                    Console.WriteLine($"{"Status:",-15} | {"The contract is still valid"}");
                    Console.WriteLine($"{"Start Date:",-15} | {c.GetStartDate()}");
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
            }
        }
        public void AddRatingHistory(Rating r)
        {
            this.ratingHistory.Add(r);
        }
        public void DisplayRatingHistory()
        {
            foreach (Rating r in this.ratingHistory)
            {
                r.PrintFeedback();
            }
        }
        public override string toString()
        {
            string id = $"Maid ID: {this.maidID}\t";
            string info = base.toString();
            id = id + info;
            return id;
        }
        
            
        
    }

}
