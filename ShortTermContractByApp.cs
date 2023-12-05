using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ShortTermContractByApp : ContractByApp
    {
        protected float hourPerDay;

        public ShortTermContractByApp(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, string workDescription, string location, float hourPerDay) : base(startDate, endDate, duration, employer, domesticHelper, workDescription, location)
        {
        }
        public ShortTermContractByApp(DateTime startDate, DateTime endDate, Employer employer, DomesticHelper domesticHelper, string workDescription, string location, float hourPerDay) : base(startDate, endDate, employer, domesticHelper, workDescription, location)
        {

        }
        public ShortTermContractByApp(Employer employer, DomesticHelper domesticHelper) : base(employer, domesticHelper)
        {
            SetupContract();
        }
        public override void PrintContract()
        {
            base.PrintContract();
            Console.WriteLine("Article 1: Term and contract work");
            Console.WriteLine("1. Type of labor contract: Labor contract with a term of " + this.duration + " days");
            Console.WriteLine("2. Since " + this.startDate.ToShortDateString() + " to " + this.endDate.ToShortDateString());
            Console.WriteLine("3. Location: " + this.location);
            Console.WriteLine("4. Job description: " + this.workDescription);
            Console.WriteLine("5. Type: Part time");
            Console.WriteLine("6. Working hours: " + this.hourPerDay);
            Console.WriteLine("Article 2: Rights of employee");
            Console.WriteLine("1. Salary: " + this.domesticHelper.getSalaryOffer());
            Console.WriteLine("2. Bonus regime: Hihihi");
            Console.WriteLine("------------------------------------------- END -------------------------------------------");
        }
        public override void SetupContract()
        {
            base.SetupContract();
            Console.WriteLine("Input hours per day: ");
            this.hourPerDay = float.Parse(Console.ReadLine());
            Console.WriteLine("Input duration (day): ");
            this.duration = int.Parse(Console.ReadLine());
            DateTime d = DateTime.Now;
            this.startDate = d;
            this.endDate = d.AddDays(this.duration);
        }
    }
}
