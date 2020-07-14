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

        public string ScalesType { get; set; }

        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>integer</returns>
        public int LayEgg()
        {
            return 5;
        }

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string</returns>
        public string Shed()
        {
            string ShedString = "It shed it's skin";
            return ShedString;
        }
    }
}
