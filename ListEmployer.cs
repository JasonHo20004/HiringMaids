//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ListEmployer
//    {
//        static List<Employer> listEmployer = new List<Employer>();
//        public ListEmployer()
//        {
//        }
//        public static List<Employer> ImportData()
//        {
//            try
//            {
//                string filePath = @"E:\\HCM_UTE\\Semester 3\\OOP\\Final_Project_OOP\\ListEmployer.txt";
//                using (StreamReader reader = new StreamReader(filePath))
//                {
//                    string line;
//                    while ((line = reader.ReadLine()) != null)
//                    {
//                        string[] listInfo = line.Split(';');
//                        string id = listInfo[0];
//                        string name = listInfo[1];
//                        string phone = listInfo[2];
//                        string address = listInfo[3];
//                        string dob = listInfo[4];
//                        float offerSlary = float.Parse(listInfo[5]);
//                        string mode = listInfo[6];
//                        string maidID = listInfo[7];
//                        List<string> skills = new List<string>();
//                        for (int i = 8; i < listInfo.Length; i++)
//                        {
//                            skills.Add(listInfo[i]);
//                        }
//                        DomesticHelper staff = new DomesticHelper(id, name, phone, address, dob, offerSlary, skills, mode, maidID);
//                        listHelper.Add(staff);
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine(e.StackTrace);
//            }
//            return listHelper;
//        }
//    }
//}
