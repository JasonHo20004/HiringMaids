using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ShortTermContractByBroker : Contract
    {
        protected float hourPerDay;
        protected double commission;
        public Broker broker;

        public ShortTermContractByBroker(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, Broker broker, string workDescription, string location, float hourPerDay, double commission)
            : base(startDate, endDate, duration, employer, domesticHelper, workDescription, location)
        {
            this.hourPerDay = hourPerDay;
            this.broker = broker;
            this.commission = commission;
        }

        public ShortTermContractByBroker(Employer employer, DomesticHelper domesticHelper) : base(employer, domesticHelper)
        {
            setupContract();
        }

        public override void printContract()
        {
            base.printContract();
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

        public override void setupContract()
        {
            base.setupContract();
            Console.Write("Input hours per day: ");
            float.TryParse(Console.ReadLine(), out this.hourPerDay);
            Console.Write("Input duration (days): ");
            int.TryParse(Console.ReadLine(), out this.duration);
            DateTime d = DateTime.Now;
            this.startDate = d;
            this.endDate = d.AddDays(this.duration);
            Console.Write("Input broker name: ");
            string brokerName = Console.ReadLine();
            //this.broker = new Broker(brokerName);
        }
    }
}
