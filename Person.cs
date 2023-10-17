using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string Name { get; set; }
        private string PhoneNumber { get; set; }
        private string Address { get; set; }
        private DateTime Dob { get; set; }

        public Person(string name, string phoneNumber, string address, DateTime dob)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Dob = dob;
        }
    }

}
