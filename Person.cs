using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
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
        // Methods
    }

}
