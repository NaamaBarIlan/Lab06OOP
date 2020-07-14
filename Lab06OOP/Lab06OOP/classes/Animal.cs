using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        public string GetFed()
        {
            string FeedString = "Time for Lunch";
            return FeedString;
        }

        public string GetSleep()
        {
            string SleepString = "Time for Sleep";
            return SleepString;
        }
    }

   
}
