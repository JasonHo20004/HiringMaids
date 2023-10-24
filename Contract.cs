using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contract
    {
        //private DateTime Duration { get; set; }
        //private string Broker { get; set; }
        //private float Commission { get; set; }
        //private string Status { get; set; }
        //private DomesticHelper DomesticHelper { get; set; }
        //private Employer Employer { get; set; }

        // Atrributes
        protected DateTime duration;
        protected string broker;
        protected float commission;
        protected bool status;
        protected DomesticHelper domesticHelper;
        protected Employer employer;
        protected DateTime startDate;
        protected DateTime endDate;
        protected string location;
        protected float hoursWork;

        // Constructors
        public Contract(DateTime duration, string broker, float commission, bool status, DomesticHelper domesticHelper, Employer employer, DateTime startDate, DateTime endDate, string location, float hoursWork)
        {
            this.duration = duration;
            this.broker = broker;
            this.commission = commission;
            this.status = status;
            this.domesticHelper = domesticHelper;
            this.employer = employer;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.hoursWork = hoursWork;
        }

        // Methods



    }

}
