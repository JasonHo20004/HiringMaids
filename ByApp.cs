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

            DomesticHelper staff1 = new DomesticHelper("052204007418", "Dat", "0123", "Quan 1", new DateTime(2023, 1, 1), 100, new List<string> { "cooking", "cleaning" }, 'F', "DH01");
            listHelper.Add(staff1);
            DomesticHelper staff2 = new DomesticHelper("052204007418", "Vu", "0123", "Quan 2", new DateTime(2023, 06, 24), 100, new List<string> { "cooking" }, 'P', "DH02");
            listHelper.Add(staff2);
            DomesticHelper staff3 = new DomesticHelper("052204007418", "Loc", "0123", "Thu Duc", new DateTime(2023, 1, 24), 100, new List<string> { "cooking", "taking care of child" }, 'P', "DH03");
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
                    helper.printInfoOnRow();
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
        public void signContract()
        {
            Console.Write("Input the Helper's ID: ");
            string maidID = Console.ReadLine();
            maidID = maidID.ToUpper();
            DomesticHelper d = searchIDHelper(maidID);
            if (d != null)
            {
                Console.WriteLine("Are you sure you want to hire this person? ( Y/N ?)");
                d.printInforInColumn();
                string s = Console.ReadLine();
                s = s.ToUpper();
                if (s == "Y")
                {
                    if(d.GetWorkMode()=='F')
                    {
                        LongtermContract l = new LongtermContract(this.employer,d);
                        this.employer.ListContract.Add(l);
                        d.ListContracts.Add(l);
                        l.printContract();
                    }    
                    else
                    {
                        ShorttermContract l = new ShorttermContract(this.employer, d);
                        this.employer.ListContract.Add(l);
                        d.ListContracts.Add(l);
                        l.printContract();
                    }
                }
            }
        }
        public void setupContract()
        {
            Console.Write("Describe detail tasks: ");
            string s = Console.ReadLine();
            Console.Write("Input location: ");
            string l = Console.ReadLine();
        }



    }
}