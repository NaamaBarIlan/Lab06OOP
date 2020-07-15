using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of an abstract class that inherits info from the base class Animal
/// </summary>
     public abstract class Mammal : Animal
    {
        public bool BloodType { get; set; }
        /// <summary>
        /// below is an abstract property that is inherited by its derived classes
        /// </summary>
        public abstract string HairType { get; set; }
       
    
       
        /// <summary>
        /// below is an override method that is taken from an abstract method in the Animal class
        /// </summary>
        /// <returns>string with the value of "Ran out of Food"</returns>
        /// 
        public override string GetFed()
        {
            string NewFeedString = "Ran out of Food";
            return NewFeedString;
        }

        /// <summary>
        /// below is an override method that is taken from an abstract method in the Animal class
        /// </summary>
        /// <returns>string with the value of "Aint no rest for the wicked"</returns>
        /// 
        public override string GetSleep()
        {
            string NewSleepString = "Aint no rest for the wicked";
            return NewSleepString;
        }

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Produce Milk"</returns>
        /// 
        public string ProduceMilk()
        {
            string ProduceMilkString = "Produce Milk";
            return ProduceMilkString;
        }

        /// <summary>
        /// below is a virtual method that returns a integer when run
        /// </summary>
        /// <returns>int with value of 3</returns>
        public virtual int HasYoung()
        {
            return 3;
        }
    }

    

}
