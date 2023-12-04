﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListHelper
    {
        static List<DomesticHelper> listHelper = new List<DomesticHelper>();
        public ListHelper()
        {
        }
        public static List<DomesticHelper> ImportData()
        {
            try
            {
                string filePath = @"C:\\OOP C#\\HiringMaids-VuCodeSpace\\ListHelper.txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {

                        string[] listInfo=line.Split(';');
                        string id=listInfo[0];
                        string name=listInfo[1];
                        string phone=listInfo[2];
                        string address=listInfo[3];
                        string dob=listInfo[4];
                        float offerSlary=float.Parse(listInfo[5]);
                        string mode=listInfo[6];
                        string maidID=listInfo[7];
                        List<string> skills = new List<string>();
                        for(int i=8;i<listInfo.Length;i++)
                        {
                            skills.Add(listInfo[i]);
                        }
                        DomesticHelper staff=new DomesticHelper(id,name,phone,address,dob,offerSlary,skills,mode,maidID);
                        listHelper.Add(staff);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return listHelper;
        }
    }
}
