using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of a class that inherits from the base classes Reptile and Animal
/// </summary>
    public abstract class Snake : Reptile
    {
        public bool Venemous { get; set; }
        public int Length { get; set; }

        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>integer with value of 5</returns>
        public int Slither()
        {
            return 5;
        }

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Ow"</returns>
        public string Bite()
        {
            string BiteString = "Ow";
            return BiteString;
        }
    }
}
