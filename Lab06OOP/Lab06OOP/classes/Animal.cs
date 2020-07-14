using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of the abstract class Animal
/// </summary>
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        /// <summary>
        /// below is a method that returns a string when GetFed is run
        /// </summary>
        /// <returns>string with value "time for lunch"</returns>
        public string GetFed()
        {
            string FeedString = "Time for Lunch";
            return FeedString;
        }

        /// <summary>
        /// below is a method that returns a string when GetSleep is run
        /// </summary>
        /// <returns>string with value of "time for sleep"</returns>
        public string GetSleep()
        {
            string SleepString = "Time for Sleep";
            return SleepString;
        }
    }

   
}
