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
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{"Name:",-15} | {this.name}");
            Console.WriteLine($"{"ID:",-15} | {this.id}");
            Console.WriteLine($"{"Date of birth:",-15} | {this.dob.ToShortDateString()}");
            Console.WriteLine($"{"Phone number:",-15} | {this.phoneNumber}");
            Console.WriteLine($"{"Address:",-15} | {this.address}");
            Console.WriteLine("----------------------------");
        }

    }

}
