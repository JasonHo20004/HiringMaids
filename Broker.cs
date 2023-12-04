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
        List<Broker> brokers;
        double commission;
        string brokerID; // Broker ID để employee chọn

        public Broker(string id, string name, string phoneNumber, string address, string dob, List<DomesticHelper> listHelper, double commission, string brokerID) : base(id, name, phoneNumber, address, dob)
        {
            this.listHelper = listHelper;
            this.commission = commission;
            this.brokerID = brokerID;
            //this.brokers = new List<Broker>();
        }
        public List<DomesticHelper> GetListHelpers()
        {
            return this.listHelper;
        }
        public void AddBroker(Broker broker)
        {
            brokers.Add(broker);
        }
        public string GetBrokerId()
        {
            return this.brokerID;
        }
        public Broker SelectBroker(string brokerId)
        {
            return brokers.FirstOrDefault(broker => broker.GetBrokerId() == brokerId);
        }

        public void ShowHelpers()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} | {7, -15} | {8, -15}", "Helper ID", "Name", "ID", "Date of Birth", "Phone Number", "Address", "WorkMode", "SalaryOffer", "Skills");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (DomesticHelper helper in listHelper)
            {
                string text = String.Format("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} | {7, -15} | {8, -15}",
                    helper.getMaidID(), helper.getName(), helper.getID(), helper.getDob().ToShortDateString(), helper.getPhoneNumber(), helper.getAddress(), helper.GetWorkMode(), helper.getSalaryOffer(), helper.GetSkills());
                //Console.Write("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} | {7, -15} | {8, -15}",
                //    helper.getMaidID(), helper.getName(), helper.getID(), helper.getDob().ToShortDateString(), helper.getPhoneNumber(), helper.getAddress(), helper.GetWorkMode(), helper.getSalaryOffer(), helper.GetSkills());
                //Console.WriteLine();
                Console.WriteLine(text);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        public DomesticHelper SelectHelper(string helperId)
        {
            return listHelper.FirstOrDefault(helper => helper.getMaidID() == helperId);
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
