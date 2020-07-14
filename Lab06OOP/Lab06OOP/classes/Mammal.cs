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
        public string HairType { get; set; }
        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Produce Milk"</returns>
        public string ProduceMilk()
        {
            string ProduceMilkString = "Produce Milk";
            return ProduceMilkString;
        }

        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>int with value of 3</returns>
        public int HasYoung()
        {
            return 3;
        }
    }

    

}
