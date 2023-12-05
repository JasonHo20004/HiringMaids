using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ByApp : Hiring
    {
        // Attributes
        List<DomesticHelper> listHelper = Data.ImportHelperData();
        Employer employer;
        // Constructor
        public ByApp(Employer employer)
        {
            //createData();
            this.employer = employer;
        }
        // Methods 

        public void printListDomesticHelper()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} | {7, -15} | {8, -15}", "Helper ID", "Name", "ID", "Date of Birth", "Phone Number", "Address", "WorkMode", "SalaryOffer", "Skills");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (DomesticHelper d in listHelper)
            {
                Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} | {7, -15} | {8, -15}",
                    d.getMaidID(), d.GetName(), d.getID(), d.getDob().ToShortDateString(), d.getPhoneNumber(), d.getAddress(), d.GetWorkMode(), d.getSalaryOffer(), d.GetSkills());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void inputSalaryOffer()
        {
            float x = float.Parse(Console.ReadLine());
            this.employer.SetSalaryOffer(x);
        }

        public void filterDomesticHelper()
        {

            bool continueFiltering = true;
            while (continueFiltering)
            {
                Console.WriteLine("Input offer salary: ");
                inputSalaryOffer();
                var filteredBySalary = listHelper.Where(helper => helper.getSalaryOffer() <= employer.GetSalaryOffer());
                if (!filteredBySalary.Any())
                {
                    Console.WriteLine("No domestic helper suits your salary offer. Do you want to input again? (Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") return;
                    else continue;
                }
                Console.WriteLine("Input the number of requirements: ");
                int n = int.Parse(Console.ReadLine());
                List<string> list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Requirement " + (i + 1));
                    string s = Console.ReadLine();
                    s = s.ToLower();
                    list.Add(s);
                }
                var filteredBySkills = filteredBySalary.Where(helper => list.All(req => helper.HasSkill(req)));
                if (!filteredBySkills.Any())
                {
                    Console.WriteLine("No domestic helper has all the required skills. Do you want to input again? (Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") return;
                    else continue;
                }

                Console.WriteLine("Input desired location: ");
                string location = Console.ReadLine().ToLower();
                var filteredByLocation = filteredBySkills.Where(helper => helper.GetLocation().ToLower() == location);
                if (!filteredByLocation.Any())
                {
                    Console.WriteLine("No domestic helper is in the desired location. Do you want to input again? (Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") return;
                    else continue;
                }

                Console.WriteLine("Input work mode (P: Part-time/ F: Full-time): ");
                string workMode = Console.ReadLine().ToLower();
                var filteredStaff = filteredByLocation.Where(helper => helper.GetWorkMode().ToString().ToLower() == workMode);
                if (!filteredStaff.Any())
                {
                    Console.WriteLine("No domestic helper suits your work mode. Do you want to input again? (Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") return;
                    else continue;
                }

                Console.WriteLine("======== Filtered Domestic Helpers ========");
                foreach (var helper in filteredStaff)
                {
                    helper.PrintInfoOnRow();
                }
                continueFiltering = false;
            }
        }
        DomesticHelper searchIDHelper(string id)
        {
            foreach (DomesticHelper d in listHelper)
            {
                if (d.getMaidID() == id) return d;
            }
            return null;
        }
        public override void SignContract()
        {
            Console.Write("Input the Helper's ID: ");
            string maidID = Console.ReadLine();
            maidID = maidID.ToUpper();
            DomesticHelper d = searchIDHelper(maidID);
            if (d != null)
            {
                Console.WriteLine("Are you sure you want to hire this person? ( Y/N ?)");
                d.PrintInforInColumn();
                string s = Console.ReadLine();
                s = s.ToUpper();
                if (s == "Y")
                {
                    //employer.AddHireHistory(d);
                    if (d.GetWorkMode() == "F")
                    {
                        LongtermContractByApp l = new LongtermContractByApp(this.employer, d);
                        this.employer.ListContract.Add(l);
                        d.ListContracts.Add(l);
                        l.PrintContract();
                    }
                    else
                    {
                        ShortTermContractByApp l = new ShortTermContractByApp(this.employer, d);
                        this.employer.ListContract.Add(l);
                        d.ListContracts.Add(l);
                        l.PrintContract();
                    }
                }
            }
        }
    }
}
