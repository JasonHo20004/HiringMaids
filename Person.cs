using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Person
    {
        //Atrributes
        protected string name;
        protected string phoneNumber;
        protected string address;
        protected DateTime dob;
        
        //Constructor
        public Person(string name, string phoneNumber, string address, DateTime dob)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.dob = dob;
        }
        public Person() { }
        // Methods
        public virtual string toString()
        {
            string info = $"Name: {name}\t";
            info += $"Phone Number: {phoneNumber}\t";
            info += $"Address: {address} \t";
            info += $"Date of Birth: {dob.ToShortDateString()} \t";         
            return info;
        }
        public virtual void printInfo()
        {
            Console.WriteLine(toString());
        }
    }

}
