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
            DomesticHelper staff1 = new DomesticHelper("Dat", "0123", "Tay Ninh", new DateTime(2023, 1, 1), 100, new List<string> { "cooking", "cleaning" }, "DH01");
            listHelper.Add(staff1);
            DomesticHelper staff2 = new DomesticHelper("Vu", "0123", "Binh Dinh", new DateTime(2023, 06, 24), 100, new List<string> { "cooking" }, "DH02");
            listHelper.Add(staff2);
            DomesticHelper staff3 = new DomesticHelper("Loc", "0123", "Binh Dinh", new DateTime(2023, 1, 24), 100, new List<string> { "cooking", "taking care of child" }, "DH03");
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
            Console.WriteLine("Input offer salary: ");
            inputSalaryOffer();
            Console.WriteLine("Input the number of requirements: ");
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Requirement " + (i + 1));
                string s = Console.ReadLine();
                list.Add(s);
            }
            // Lọc ra những staff thõa requirements 
            var filteredStaff = listHelper.Where(helper =>helper.getSalaryOffer() <= employer.getSalaryOffer() 
                                                &&list.All(req => helper.HasSkill(req)));

            if (filteredStaff.Count() > 0)
            {
                Console.WriteLine("Filtered Domestic Helpers:");
                foreach (var helper in filteredStaff)
                {
                    helper.printInfo();
                }
            }
            else { Console.WriteLine("Empty data !!!"); }
        }


    }
}
