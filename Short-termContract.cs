using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShorttermContract : Contract
    {
        private int HoursWork { get; set; }
        private string Location { get; set; }

        private ShorttermContract(DateTime duration, string broker, float commission, string status, DomesticHelper domesticHelper, Employer employer, int hoursWork, string location) : base(duration, broker, commission, status, domesticHelper, employer)
        {
            HoursWork = hoursWork;
            Location = location;
        }
    }
}
