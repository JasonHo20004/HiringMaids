﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("052204007418","Huy", "0123", "HCM", new DateTime(2023, 1, 1));
            ByApp a = new ByApp(employer);

            //a.filterDomesticHelper();
            Console.WriteLine(employer.ListContract.Count());
            a.signContract();
            Console.WriteLine(employer.ListContract.Count());
        }
    }
}