using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{/// <summary>
/// below is the creation of a class that inherits info from the base classes Mammal and Animal
/// </summary>
    public class MarinaRam : Mammal
    {
        public int HornLength { get; set; }
        public int LifeAltitude { get; set; }

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Ram"</returns>
        public string Ram()
        {
            string RamString = "Ram";
            return RamString;
        }
        /// <summary>
        /// below is a method that returns an integer when run
        /// </summary>
        /// <returns>integer with value of 12000</returns>
        public int Climb()
        {
            return 12000;
        }
    }
}
