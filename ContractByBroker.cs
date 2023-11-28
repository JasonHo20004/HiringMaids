using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContractByBroker : Contract
    {
        protected double commission;
        public Broker brokers;

        public ContractByBroker(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, Broker broker, string workDescription, string location, double commission) : base(employer, domesticHelper)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.duration = duration;
            this.employer = employer;
            this.workDescription = workDescription;
            this.location = location;
            this.commission = commission;
            this.brokers = broker;
        }

        public override void printContract()
        {
            Console.WriteLine("----------------------------- LABOR CONTRACT FOR HIRE MAID -----------------------------");
            Console.WriteLine("Party A - Employer ");
            this.employer.printInforInColumn();
            Console.WriteLine("Party B - Domestic Helper ");
            this.domesticHelper.printInforInColumn();
            Console.WriteLine("Party C - Broker ");
            this.brokers.printInforInColumn();
        }
        public override void setupContract()
        {
            Console.Write("Describe detail tasks: ");
            this.workDescription = Console.ReadLine();
            Console.Write("Input location: ");
            this.location = Console.ReadLine();
        }
    }
}
