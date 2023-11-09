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

        public ByBroker(Employer employer)
        {
            this.employer = employer;
            suggestedHelpers = new List<DomesticHelper>();
            createData();
        }

        public void createData()
        {
            DomesticHelper helper1 = new DomesticHelper("052204007418", "Dat", "0123", "Quan 1", new DateTime(2023, 1, 1), 100, new List<string> { "cooking", "cleaning" }, "F", "DH01");
            suggestedHelpers.Add(helper1);
            DomesticHelper helper2 = new DomesticHelper("052204007418", "Vu", "0123", "Quan 2", new DateTime(2023, 06, 24), 100, new List<string> { "cooking" }, "P", "DH02");
            suggestedHelpers.Add(helper2);
        }

        public void ShowSuggestedHelpers()
        {
            foreach (DomesticHelper helper in suggestedHelpers)
            {
                helper.printInfoOnRow();
            }
        }

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
        }
    }
}

