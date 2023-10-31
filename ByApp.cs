using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ByApp
    {
        // Attributes
        List<DomesticHelper> listHelper;
        Employer employer;
        // Constructor
        public ByApp(Employer employer)
        {
            createData();
            this.employer = employer;
        }
        // Methods
        public void createData()
        {
            listHelper = new List<DomesticHelper>();
            DomesticHelper staff1 = new DomesticHelper("Dat", "0123", "Quan 1", new DateTime(2023, 1, 1), 120, new List<string> { "cooking", "cleaning" }, "DH01", "Full-Time");
            listHelper.Add(staff1);
            DomesticHelper staff2 = new DomesticHelper("Vu", "0123", "Quan 2", new DateTime(2023, 06, 24), 150, new List<string> { "cooking" }, "DH02", "Part-time");
            listHelper.Add(staff2);
            DomesticHelper staff3 = new DomesticHelper("Loc", "0123", "Thu Duc", new DateTime(2023, 1, 24), 200, new List<string> { "cooking", "taking care of child" }, "DH03", "Full-Time");
            listHelper.Add(staff3);
        }
        public void printListDomesticHelper()
        {
            foreach (DomesticHelper d in listHelper)
            {
                d.printInfo();
            }
        }
        public void inputSalaryOffer()
        {
            float x = float.Parse(Console.ReadLine());
            this.employer.setSalaryOffer(x);
        }

        public void filterDomesticHelper()
        {
            bool continueFiltering = true;
            while (continueFiltering)
            {
                Console.WriteLine("Input offer salary: ");
                inputSalaryOffer();
                var filteredBySalary = listHelper.Where(helper => helper.getSalaryOffer() <= employer.getSalaryOffer());
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

                Console.WriteLine("Input work mode (part-time/full-time): ");
                string workMode = Console.ReadLine().ToLower();
                var filteredStaff = filteredByLocation.Where(helper => helper.GetWorkMode().ToLower() == workMode);
                if (!filteredStaff.Any())
                {
                    Console.WriteLine("No domestic helper suits your work mode. Do you want to input again? (Y/N)");
                    if (Console.ReadLine().ToUpper() != "Y") return;
                    else continue;
                }

                Console.WriteLine("======== Filtered Domestic Helpers ========");
                foreach (var helper in filteredStaff)
                {
                    helper.printInfo();
                }
                continueFiltering = false;
            }
        }
    }
}
