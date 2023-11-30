using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ContractByApp : Contract
    {
        // Atrributes
        //new protected int duration;
        //new protected bool status;
        //new protected DomesticHelper domesticHelper;
        //new protected Employer employer;
        //new protected DateTime startDate;
        //new protected DateTime endDate;
        //new protected string location;
        //new protected string workDescription;

        // Constructors
        public ContractByApp(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, string workDescription, string location) : base(startDate, endDate,duration,employer,domesticHelper,workDescription,location)
        {
     
        }
        public ContractByApp(DateTime startDate, DateTime endDate, Employer employer, DomesticHelper domesticHelper, string workDescription, string location) : base(employer, domesticHelper)
        {

            this.status = true;
            this.domesticHelper = domesticHelper; 
            this.employer = employer;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.workDescription = workDescription;

        }

        public ContractByApp(Employer employer, DomesticHelper domesticHelper) : base(employer,domesticHelper)
        {          
        }
        // Methods
        public override void printContract()
        {
            Console.WriteLine("----------------------------- LABOR CONTRACT FOR HIRE MAID -----------------------------");
            Console.WriteLine("Party A - Employer ");
            this.employer.printInforInColumn();
            Console.WriteLine("Party B - Domestic Helper ");
            this.domesticHelper.printInforInColumn();
        }

        public virtual void printContract()
        {
            Console.WriteLine("----------------------------- LABOR CONTRACT FOR HIRE MAID -----------------------------");
            Console.WriteLine("Party A - Employer ");
            this.employer.printInforInColumn();
            Console.WriteLine("Party B - Domestic Helper ");
            this.domesticHelper.printInforInColumn();
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
