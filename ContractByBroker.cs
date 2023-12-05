using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContractByBroker : Contract
    {
        //protected double commission;
        protected Broker brokers;
        public ContractByBroker(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, string workDescription, string location, Broker broker) : base(startDate, endDate, duration, employer, domesticHelper, workDescription, location)
        {
            this.brokers = broker;
        }
        public ContractByBroker(Employer employer, DomesticHelper domesticHelper, Broker broker) : base(employer, domesticHelper)
        {

            this.brokers = broker;

        }
        public override void PrintContract()
        {
            base.PrintContract();
            Console.WriteLine("Party C - Broker ");
            this.brokers.PrintInforInColumn();
        }  
    }
}
