using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LongtermContract : Contract
    {
        public LongtermContract(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, string workDescription, string location) : base(startDate, endDate, duration, employer, domesticHelper, workDescription, location)
        {

        }

        public LongtermContract(DateTime startDate, DateTime endDate, Employer employer, DomesticHelper domesticHelper, string workDescription, string location) : base(startDate, endDate, employer, domesticHelper, workDescription, location)
        {
            this.duration = 6;
        }
        public LongtermContract(Employer employer, DomesticHelper domesticHelper) : base(employer, domesticHelper)
        {

            this.duration = 6;
            setupContract();
        }
        public override void printContract()
        {
            base.printContract();
            Console.WriteLine("Article 1: Term and contract work");
            Console.WriteLine(". Type of labor contract: Labor contract with a term of " + this.duration + " months");
            Console.WriteLine(". Since " + this.startDate.ToShortDateString() + " to " + this.endDate.ToShortDateString());
            Console.WriteLine(". Location: " + this.location);
            Console.WriteLine(". Job description: " + this.workDescription);
            Console.WriteLine(". Type: Full time");
            Console.WriteLine(". Working hours: 10");
            Console.WriteLine("Article 2: Rights of employee");
            Console.WriteLine(". Salary: " + this.domesticHelper.getSalaryOffer());
            Console.WriteLine(". Bonus regime: Hihihi");
            Console.WriteLine("------------------------------------------- END -------------------------------------------");
        }
        public void SetupContract()
        {
            base.setupContract();
            DateTime d = DateTime.Now;
            this.startDate = d;
            this.endDate = d.AddMonths(this.duration);
        }
    }

}
