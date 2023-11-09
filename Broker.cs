using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Broker : Person
    {
        List<DomesticHelper> listHelper;
        double commission;
        string brokerID; // Broker ID để employee chọn
        public Broker(string id, string name, string phoneNumber, string address, DateTime dob, List<DomesticHelper> listHelper, double commission, string brokerID) : base(id, name, phoneNumber, address, dob)
        {
            this.listHelper = listHelper;
            this.commission = commission;
            this.brokerID = brokerID;
        }
        public double getCommission()
        {
            return this.commission;
        }
        public override string toString()
        {
            string info = $"Name: {name}\t";
            info += $"Broker's ID: {brokerID}\t";
            info += $"Date of Birth: {dob.ToShortDateString()} \t";
            info += $"Phone Number: {phoneNumber}\t";
            info += $"Commission: {commission}\t";
            return info;
        }
    }
}
