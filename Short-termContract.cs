﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShorttermContract : Contract
    {
        public ShorttermContract(DateTime duration, string broker, float commission, bool status, DomesticHelper domesticHelper, Employer employer, DateTime startDate, DateTime endDate, string location, float hoursWork) : base(duration, broker, commission, status, domesticHelper, employer, startDate, endDate, location, hoursWork)
        {
        }
    }
}
