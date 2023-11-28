using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rating
    {
        //Attributes
        int score;
        string comment;
        // Constructor
        public Rating(int score, string comment)
        {
            this.score = score;
            this.comment = comment;
        }
        public void InputRating()
        {
            Console.Write("Enter score: ");
            int n=int.Parse(Console.ReadLine());
            this.score = n;
            Console.Write("Enter your feedback: ");
            this.comment = Console.ReadLine();
        }
        //Methods
    }
}
