﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contract
    {
        //private DateTime Duration { get; set; }
        //private string Broker { get; set; }
        //private float Commission { get; set; }
        //private string Status { get; set; }
        //private DomesticHelper DomesticHelper { get; set; }
        //private Employer Employer { get; set; }

        // Atrributes
        protected int duration;
        //protected string broker;
        //protected float commission;
        protected bool status;
        protected DomesticHelper domesticHelper;
        protected Employer employer;
        protected DateTime startDate;
        protected DateTime endDate;
        protected string location;
        //protected float hoursWork;
        protected string workDescription;



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
        public Contract(DateTime startDate, DateTime endDate,  Employer employer, DomesticHelper domesticHelper, string workDescription, string location)
        {
            
            this.status = true;
            this.domesticHelper = domesticHelper;
            this.employer = employer;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.workDescription = workDescription;

        }

        public Contract(Employer employer, DomesticHelper domesticHelper)
        {
            this.employer = employer;
            this.domesticHelper = domesticHelper;
        }
        // Methods
        public virtual void printContract()
        {
            Console.WriteLine("----------------------------- LABOR CONTRACT FOR HIRE MAID -----------------------------");
            Console.WriteLine("Party A - Employer ");
            this.employer.printInforInColumn();
            Console.WriteLine("Party B - Domestic Helper ");
            this.domesticHelper.printInforInColumn();
        }

        public virtual void setupContract()
        {
            Console.Write("Describe detail tasks: ");
           this.workDescription = Console.ReadLine();
            Console.Write("Input location: ");
            this.location = Console.ReadLine();
        }



    }

}
