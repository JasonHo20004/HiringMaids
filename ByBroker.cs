using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ByBroker:Hiring
    {
        // In thông tin của từng Broker thì dùng hàm printInforOnRow nha, in vậy để Employee dễ xem dễ chọn
        private List<DomesticHelper> suggestedHelpers;
        private Employer employer;
        private List<Broker> brokers = Data.ImportBrokerData();
        public ByBroker(Employer employer)
        {
            this.employer = employer;
            suggestedHelpers = new List<DomesticHelper>();
        }
        public void ShowSuggestedHelpers()
        {
            foreach (DomesticHelper helper in suggestedHelpers)
            {
                helper.PrintInfoOnRow();
            }
        }
        public void ShowListBroker()
        {

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15} ", "Broker's ID", "Name", "Date of Birth", "ID", "Phone Number", "Address", "Commission");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (Broker b in brokers)
            {
                Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5, -15} | {6, -15}",
                 b.GetBrokerId(), b.GetName(), b.getDob().ToShortDateString(), b.getID(), b.getPhoneNumber(), b.getAddress(), b.getCommission());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");


        }      

        public override void SignContract()
        {
            ShowListBroker();
            Console.Write("Enter the ID of the broker you want to choose: ");
            string brokerId = Console.ReadLine();

            Broker selectedBroker = brokers.FirstOrDefault(broker => broker.GetBrokerId() == brokerId);

            if (selectedBroker != null)
            {
                Console.WriteLine("You selected the following broker:");
                Console.WriteLine(selectedBroker.toString());

                selectedBroker.ShowHelpers();

                Console.Write("Enter the ID of the helper you want to hire: ");
                string helperId = Console.ReadLine();

                DomesticHelper selectedHelper = selectedBroker.SelectHelper(helperId);

                if (selectedHelper != null)
                {
                    Console.WriteLine("You selected the following helper:");
                    selectedHelper.PrintInforInColumn();

                    Console.WriteLine("Do you want to sign a contract with this helper? (Y/N)");
                    string response = Console.ReadLine();

                    if (response.ToUpper() == "Y")
                    {
                        Contract contract;
                        if (selectedHelper.GetWorkMode() == "F")
                        {
                            contract = new LongTermContractByBroker(employer, selectedHelper, selectedBroker);
                        }
                        else
                        {
                            contract = new ShortTermContractByBroker(employer, selectedHelper, selectedBroker);
                        }
                        employer.ListContract.Add(contract);
                        selectedHelper.ListContracts.Add(contract);

                        contract.PrintContract();
                    }
                }
                else
                {
                    Console.WriteLine("No helper found with the provided ID.");
                }
            }
            else
            {
                Console.WriteLine("No broker found with the provided ID.");
            }
        }
    }
}


