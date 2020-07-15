using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of an abstract class that inherits info from the base class Animal
/// </summary>
    public abstract class Reptile : Animal
    {
        public bool BloodType { get; set; }

        public abstract string ScalesType { get; set; }


        /// <summary>
        /// below is an override method that is taken from an abstract method in the Animal class
        /// </summary>
        /// <returns>string with the value of "Found a Rabbit"</returns>
        /// 
        public override string GetFed()
        {
            string NewFeedString = "Found a Rabbit";
            return NewFeedString;
        }

        /// <summary>
        /// below is an override method that is taken from an abstract method in the Animal class
        /// </summary>
        /// <returns>string with the value of "Too cold to sleep"</returns>
        /// 
        public override string GetSleep()
        {
            string NewSleepString = "Too cold to sleep";
            return NewSleepString;
        }
        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>integer with value of 5</returns>
        /// 
        public virtual int LayEgg()
        {
            return 5;
        }

        /// <summary>
        /// below is a protected method that returns a string when run. It is only available to itself and its derived classes
        /// </summary>
        /// <returns>string with value of "It shed it's skin"</returns>
        protected string Shed()
        {
            string ShedString = "It shed it's skin";
            return ShedString;
        }
    }
}

