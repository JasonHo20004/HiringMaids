using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Data
    {
        public Data() { }

        static List<Broker> listBroker = new List<Broker>();
        static List<DomesticHelper> listHelper = new List<DomesticHelper>();
        public static List<Broker> ImportBrokerData()
        {
            try
            {
                string filePath = @"E:\\HCM_UTE\\Semester 3\\OOP\\Final_Project_OOP\\ListBroker.txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Broker currBroker = null;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] listInfo = line.Split(';');
                        if (listInfo[0] == "BrokerInfo")
                        {
                            if (currBroker != null)
                            {
                                listBroker.Add(currBroker);
                            }
                            string id = listInfo[1];
                            string name = listInfo[2];
                            string phone = listInfo[3];
                            string address = listInfo[4];
                            string dob = listInfo[5];
                            double commission = double.Parse(listInfo[6]);
                            string brokerID = listInfo[7];
                            List<DomesticHelper> listHelpers = new List<DomesticHelper>();
                            currBroker = new Broker(id, name, phone, address, dob, listHelpers, commission, brokerID);

                        }
                        else if (listInfo[0] == "HelperInfo" && currBroker != null)
                        {
                            string id = listInfo[1];
                            string name = listInfo[2];
                            string phone = listInfo[3];
                            string address = listInfo[4];
                            string dob = listInfo[5];
                            float offerSlary = float.Parse(listInfo[6]);
                            string mode = listInfo[7];
                            string maidID = listInfo[8];
                            List<string> skills = new List<string>();
                            for (int i = 9; i < listInfo.Length; i++)
                            {
                                skills.Add(listInfo[i]);
                            }
                            DomesticHelper staff = new DomesticHelper(id, name, phone, address, dob, offerSlary, skills, mode, maidID);
                            currBroker.GetListHelpers().Add(staff);
                        }
                    }
                    if (currBroker != null)
                    {
                        listBroker.Add(currBroker);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return listBroker;
        }        
        public static List<DomesticHelper> ImportHelperData()
        {
            try
            {
                string filePath = @"E:\\HCM_UTE\\Semester 3\\OOP\\Final_Project_OOP\\ListHelper.txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] listInfo = line.Split(';');
                        string id = listInfo[0];
                        string name = listInfo[1];
                        string phone = listInfo[2];
                        string address = listInfo[3];
                        string dob = listInfo[4];
                        float offerSlary = float.Parse(listInfo[5]);
                        string mode = listInfo[6];
                        string maidID = listInfo[7];
                        List<string> skills = new List<string>();
                        for (int i = 8; i < listInfo.Length; i++)
                        {
                            skills.Add(listInfo[i]);
                        }
                        DomesticHelper staff = new DomesticHelper(id, name, phone, address, dob, offerSlary, skills, mode, maidID);
                        listHelper.Add(staff);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return listHelper;
        }

    }
}
