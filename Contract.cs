﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contract
    {
        // Atrributes
        protected int duration;
        protected bool status;
        protected DomesticHelper domesticHelper;
        protected Employer employer;
        protected DateTime startDate;
        protected DateTime endDate;
        protected string? location;
        protected string? workDescription;

        // Constructors
        public Contract(DateTime startDate, DateTime endDate, int duration, Employer employer, DomesticHelper domesticHelper, string workDescription, string location)
        {
            this.duration = duration;
            this.status = true;
            this.domesticHelper = domesticHelper;
            this.employer = employer;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.workDescription = workDescription;
        }
        //public Contract(DateTime startDate, DateTime endDate, Employer employer, DomesticHelper domesticHelper, string workDescription, string location)
        //{

        //    this.status = true;
        //    this.domesticHelper = domesticHelper;
        //    this.employer = employer;
        //    this.startDate = startDate;
        //    this.endDate = endDate;
        //    this.location = location;
        //    this.workDescription = workDescription;
            
        //}
        public Contract(Employer employer, DomesticHelper domesticHelper)
        {
            this.employer = employer;
            this.domesticHelper = domesticHelper;
            this.status = true;
        }
        // Methods
        public virtual void PrintContract()
        {
            Console.WriteLine("----------------------------- LABOR CONTRACT FOR HIRE MAID -----------------------------");
            Console.WriteLine("Party A - Employer ");
            this.employer.PrintInforInColumn();
            Console.WriteLine("Party B - Domestic Helper ");
            this.domesticHelper.PrintInforInColumn();
        }
        public virtual void SetupContract()
        {
            Console.Write("Describe detail tasks: ");
            this.workDescription = Console.ReadLine();
            Console.Write("Input location: ");
            this.location = Console.ReadLine();
        }
        public DomesticHelper GetDomesticHelper()
        {
            return this.domesticHelper;
        }
        public Employer GetEmployer()
        {
            return this.employer;
        }
        public bool GetStatus()
        {
            return this.status;
        }
        public string GetWorkDescription()
        {
            return this.workDescription;
        }
        public DateTime GetStartDate()
        {
            return this.startDate;
        }
        public DateTime GetEndDate()
        {
            return this.endDate;
        }
        public bool CheckContractStatus()
        {
            if (this.startDate <= this.endDate)
                return this.status = true;
            else return this.status = false;
        }
        public void ChangeStatusContract()
        {
            DateTime d = DateTime.Now;
            this.status = false;
            this.endDate = d;
        }
    }
}
