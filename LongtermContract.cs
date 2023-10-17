using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LongtermContract : Contract
    {
        private int RenewalTimes { get; set; }

        public LongtermContract(DateTime duration, string broker, float commission, string status, DomesticHelper domesticHelper, Employer employer, int renewalTimes) : base(duration, broker, commission, status, domesticHelper, employer)
        {
            RenewalTimes = renewalTimes;
        }
    }
}
