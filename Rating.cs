using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rating
    {
        private float Score { get; set; }
        private string Comment { get; set; }
        private DateTime Date { get; set; }

        public Rating(float score, string comment, DateTime date)
        {
            Score = score;
            Comment = comment;
            Date = date;
        }
    }
}
