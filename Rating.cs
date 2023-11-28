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
        DateTime feedbackDate;
        // Constructor
        public Rating(int score, string comment)
        {
            this.score = score;
            this.comment = comment;
        }
        public Rating() { }
        public void InputRating()
        {
            DateTime d = DateTime.Now;
            this.feedbackDate = d;
            Console.Write("Enter score: ");
            int n=int.Parse(Console.ReadLine());
            this.score = n;
            Console.Write("Enter your feedback: ");
            this.comment = Console.ReadLine();
        }
        public void PrintFeedback()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Date: "+this.feedbackDate);
            Console.WriteLine("Score: "+this.score);
            Console.WriteLine("Comment: "+this.comment);
            Console.WriteLine("**********************************");
        }
        //Methods
    }
}
