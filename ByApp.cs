﻿using ConsoleApp1;
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
            DomesticHelper staff1 = new DomesticHelper("052204007418", "Dat", "0123", "Quan 1", new DateTime(2023, 1, 1), 100, new List<string> { "cooking", "cleaning" }, "DH01");
            listHelper.Add(staff1);
            DomesticHelper staff2 = new DomesticHelper("052204007418", "Vu", "0123", "Quan 2", new DateTime(2023, 06, 24), 100, new List<string> { "cooking" }, "DH02");
            listHelper.Add(staff2);
            DomesticHelper staff3 = new DomesticHelper("052204007418", "Loc", "0123", "Thu Duc", new DateTime(2023, 1, 24), 100, new List<string> { "cooking", "taking care of child" }, "DH03");
            listHelper.Add(staff3);
        }
        public void printListDomesticHelper()
        {
            foreach (DomesticHelper d in listHelper)
            {
                d.printInfoOnRow();
            }
        }
        public void inputSalaryOffer()
        {
            float x = float.Parse(Console.ReadLine());
            this.employer.setSalaryOffer(x);
        }

        public void filterDomesticHelper()
        {
            // Bây giờ bổ sung thêm để có thể lọc theo các tiêu chí : mức lương, yêu cầu công việc, địa điểm, hình thức công việc part time hay full time
            // Bổ sung thêm vào class DomesticHelper thuộc tính hình thức làm việc để có thể quản lý hình thức làm việc của helper
            Console.Write("Input offer salary: ");
            inputSalaryOffer();
            Console.Write("Input the number of requirements: ");
            int n = int.Parse(Console.ReadLine());
            // Nhập và add vào wish list yêu cầu của người thuê
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Requirement " + (i + 1) + ": ");
                string s = Console.ReadLine();
                s = s.ToLower();
                list.Add(s);
            }
            // Lọc ra những staff thõa requirements 
            var filteredStaff = listHelper.Where(helper => helper.getSalaryOffer() <= employer.getSalaryOffer()
                                                && list.All(req => helper.HasSkill(req)));

            if (filteredStaff.Count() > 0)
            {
                Console.WriteLine("Filtered Domestic Helpers:");
                foreach (var helper in filteredStaff)
                {
                    helper.printInfoOnRow();
                }
            }
            else { Console.WriteLine("Empty data !!!"); }
        }
        DomesticHelper searchIDHelper(string id)
        {
            foreach (DomesticHelper d in listHelper)
            {
                if (d.getMaidID() == id) return d;
            }
            return null;
        }
        public void signContract()
        {
            Console.Write("Input the Helper's ID: ");
            string maidID = Console.ReadLine();
            DomesticHelper d = searchIDHelper(maidID);
            if (d != null)
            {
                Console.WriteLine("Are you sure you want to hire this person? ( Y/N ?)");
                d.printInfoOnRow();
                string s = Console.ReadLine();
                s = s.ToUpper();
                if (s == "y")
                {

                }
            }
        }
        public void setupContract()
        {
            Console.Write("Describe detail tasks: ");
            string s = Console.ReadLine();
            Console.Write("Input working hours: ");
            float h = float.Parse(Console.ReadLine());
            Console.Write("Input location: ");
            string l = Console.ReadLine();
        }


    }
}
