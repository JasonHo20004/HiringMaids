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
        //public List<DomesticHelper> hireHistory = new List<DomesticHelper>();
        public List<Rating> ratingHistory;
        public List<Contract> ListContract;
        private string eID;

        // Constructor
        public Employer(string id, string name, string phoneNumber, string address, string dob, string eID) : base(id, name, phoneNumber, address, dob)
        {
            ListContract = new List<Contract>();
            this.eID = eID;
        }
        // Methods
        public void SetSalaryOffer(float x)
        {
            this.salaryOffer = x;
        }
        public float GetSalaryOffer()
        {
            return this.salaryOffer;
        }
        public void AddRequirement(List<string> T)
        {
            this.requirements.Clear();
            this.requirements.AddRange(T);
        }
        public List<string> GetListRequirements()
        {
            return this.requirements;
        }
        public override string toString()
        {
            string id = " E_ID: " + this.eID + "\t";
            string info = base.toString();
            return id + info;
        }
        public void DisplayHireHistory()
        {
            foreach (Contract c in this.ListContract)
            {
                c.CheckContractStatus();
                DomesticHelper d = c.GetDomesticHelper();
                d.PrintSample();
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
        public void PrintSample()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Name:",-15} | {this.name}");
            Console.WriteLine($"{"ID:",-15} | {this.id}");
            Console.WriteLine($"{"Date of birth:",-15} | {this.dob.ToShortDateString()}");
            Console.WriteLine($"{"Phone number:",-15} | {this.phoneNumber}");
            Console.WriteLine($"{"Address:",-15} | {this.address}");
        }
        public void DisplayListContract()
        {
            Console.WriteLine("---------------------- List Contract ----------------------");
            int i = 0;
            foreach (Contract c in this.ListContract)
            {
                i++;
                DomesticHelper d = c.GetDomesticHelper();
                Console.Write(i + "\t" + d.GetName() + "\t" + c.GetStartDate().ToShortDateString() + "\t");
                if (c.GetStatus() == true) Console.WriteLine("Valid");
                else Console.WriteLine("Expired");
            }
        }
        public void CancelContract()
        {
            DisplayListContract();
            Console.Write("Enter: ");
            int input = int.Parse(Console.ReadLine());
            var c = this.ListContract[input - 1];
            c.PrintContract();
            Console.WriteLine("Do you want to cancel this contract ? (Y/N)");
            string s = Console.ReadLine();
            s = s.ToUpper();
            if (s == "Y")
            {
                c.ChangeStatusContract();
                Console.WriteLine("Canceled successfully!!!");
            }
            else return;
        }
        public void FeedBackHelper()
        {
            DisplayListContract();
            Console.Write("Enter: ");
            int input = int.Parse(Console.ReadLine());
            var c = this.ListContract[input - 1];
            Rating r = new Rating();
            r.InputRating();
            c.GetDomesticHelper().AddRatingHistory(r);
        }
        public void SeeRating()
        {
            foreach (Contract c in this.ListContract)
            {
                c.GetDomesticHelper().DisplayRatingHistory();
            }
        }
    }
}
