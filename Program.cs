﻿using System.Collections.Specialized;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("052204007418", "Huy", "0123", "HCM", "24/06/2004","E01");
            ByApp a = new ByApp(employer);
            a.printListDomesticHelper();
            //a.filterDomesticHelper();
            a.signContract();
            //a.setupContract();
            a.signContract();
            employer.DisplayHireHistory();
            employer.CancelContract();
            employer.DisplayListContract();
            //ByBroker b = new ByBroker(employer);
            //b.SelectBrokerAndHelper();
            //a.filterDomesticHelper();
            //Console.WriteLine(employer.ListContract.Count());
            //a.signContract();
            //Console.WriteLine(employer.ListContract.Count());
        
        }
    }
}