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
        string id;
        protected DateTime dob;

        //Constructor
        public Person(string id, string name, string phoneNumber, string address, DateTime dob)
        {
            this.id = id;
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
            info += $"Date of Birth: {dob.ToShortDateString()} \t";
            info += $"ID: {this.id} \t";
            info += $"Phone Number: {phoneNumber}\t";
            info += $"Address: {address} \t";

            return info;
        }
        public virtual void printInfoOnRow()
        {
            Console.WriteLine(toString());
        }

        public virtual void printInforInColumn()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Date of birth: " + this.dob.ToShortDateString());
            Console.WriteLine("Phone number: " + this.phoneNumber);
            Console.WriteLine("Address: " + this.address);
        }
    }

}
