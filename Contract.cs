using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contract
    {
        private DateTime Duration { get; set; }
        private string Broker { get; set; }
        private float Commission { get; set; }
        private string Status { get; set; }
        private DomesticHelper DomesticHelper { get; set; }
        private Employer Employer { get; set; }

        public Contract(DateTime duration, string broker, float commission, string status, DomesticHelper domesticHelper, Employer employer)
        {
            Duration = duration;
            Broker = broker;
            Commission = commission;
            Status = status;
            DomesticHelper = domesticHelper;
            Employer = employer;
        }
    }

}
