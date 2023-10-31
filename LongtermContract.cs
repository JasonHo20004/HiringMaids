using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LongtermContract : Contract
    {
        // LongTerm Contract can renew

        // Attributes

        // Constructor

        // Methods
        public LongtermContract(DateTime duration, string broker, float commission, bool status, DomesticHelper domesticHelper, Employer employer, DateTime startDate, DateTime endDate, string location, float hoursWork) : base(duration, broker, commission, status, domesticHelper, employer, startDate, endDate, location, hoursWork)
        {
        }
    }
}
