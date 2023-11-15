using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ByBroker
    {
        // In thông tin của từng Broker thì dùng hàm printInforOnRow nha, in vậy để Employee dễ xem dễ chọn
        private List<DomesticHelper> suggestedHelpers;
        private Employer employer;
        private List<Broker> brokers;
        public ByBroker(Employer employer)
        {
            this.employer = employer;
            suggestedHelpers = new List<DomesticHelper>();
            brokers = new List<Broker>();
            createData();
        }

        public void createData()
        {
            DomesticHelper helper1 = new DomesticHelper("052204007418", "Dat", "0123", "Quan 1", new DateTime(2023, 1, 1), 100, new List<string> { "cooking", "cleaning" }, "F", "DH01");
            suggestedHelpers.Add(helper1);
            DomesticHelper helper2 = new DomesticHelper("052204007418", "Vu", "0123", "Quan 2", new DateTime(2023, 06, 24), 100, new List<string> { "cooking" }, "F", "DH02");
            suggestedHelpers.Add(helper2);
            DomesticHelper helper3 = new DomesticHelper("052204007420", "Mai", "0123", "Quan 4", new DateTime(2023, 3, 15), 120, new List<string> { "cleaning" }, "F", "DH03");
            suggestedHelpers.Add(helper3);
            DomesticHelper helper4 = new DomesticHelper("052204007421", "Duc", "0123", "Quan 5", new DateTime(2023, 9, 10), 80, new List<string> { "cooking" }, "F", "DH04");
            suggestedHelpers.Add(helper4);

            Broker broker1 = new Broker("052204007419", "Xuan Huy", "0123", "Quan 3", new DateTime(2023, 06, 24), new List<DomesticHelper> { helper1, helper2 }, 100, "001");
            brokers.Add(broker1); // Add broker1 to brokers list

            Broker broker2 = new Broker("052204007422", "Ngoc Linh", "0123", "Quan 5", new DateTime(2023, 9, 10), new List<DomesticHelper> { helper3, helper4 }, 120, "002");
            brokers.Add(broker2); // Add broker2 to brokers list
        }

        public void ShowSuggestedHelpers()  
        {
            foreach (DomesticHelper helper in suggestedHelpers)
            {
                helper.printInfoOnRow();
            }
        }
        public void SelectBrokerAndHelper()
        {
            foreach (Broker broker in brokers) // Use brokers list from this class
            {
                broker.printInfoOnRow();
            }
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
                    selectedHelper.printInforInColumn();

                    Console.WriteLine("Do you want to sign a contract with this helper? (Y/N)");    
                    string response = Console.ReadLine();

                    if (response.ToUpper() == "Y")
                    {
                        Contract contract;
                        if (selectedHelper.GetWorkMode() == "F")
                        {
                            contract = new LongtermContract(employer, selectedHelper);
                        }
                        else
                        {
                            contract = new ShorttermContract(employer, selectedHelper);
                        }
                        employer.ListContract.Add(contract);
                        selectedHelper.ListContracts.Add(contract);

                        contract.printContract();
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
        /*
        public void SelectHelperAndSignContract()
        {
            Console.Write("Enter the ID of the helper you want to hire: ");
            string helperId = Console.ReadLine();

            DomesticHelper selectedHelper = suggestedHelpers.FirstOrDefault(helper => helper.getMaidID() == helperId);

            if (selectedHelper != null)
            {
                Console.WriteLine("You selected the following helper:");
                selectedHelper.printInforInColumn();

                Console.WriteLine("Do you want to sign a contract with this helper? (Y/N)");
                string response = Console.ReadLine();

                if (response.ToUpper() == "Y")
                {
                    Contract contract;
                    if (selectedHelper.GetWorkMode() == "F")
                    {
                        contract = new LongtermContract(employer, selectedHelper);
                    }
                    else
                    {
                        contract = new ShorttermContract(employer, selectedHelper);
                    }
                    employer.ListContract.Add(contract);
                    selectedHelper.ListContracts.Add(contract);

                    contract.printContract();
                }
            }
            else
            {
                Console.WriteLine("No helper found with the provided ID.");
            }
        */
    }
}


