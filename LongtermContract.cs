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

        public override void printContract()
        {
            base.printContract();
            Console.WriteLine("Article 1: Term and contract work");
            Console.WriteLine("1. Type of labor contract: Labor contract with a term of " + this.duration + " months");
            Console.WriteLine("2. Since " + this.startDate.ToShortDateString() + " to " + this.endDate.ToShortDateString());
            Console.WriteLine("3. Location: " + this.location);
            Console.WriteLine("4. Job description: " + this.workDescription);
            Console.WriteLine("5. Type: Full time");
            Console.WriteLine("6. Working hours: 10");
            Console.WriteLine("Article 2: Rights of employee");
            Console.WriteLine("1. Salary: " + this.domesticHelper.getSalaryOffer());
            Console.WriteLine("2. Bonus regime: Hihihi");
        }
    }
}
