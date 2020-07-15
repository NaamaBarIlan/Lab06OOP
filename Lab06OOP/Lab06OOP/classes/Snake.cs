using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of a class that inherits from the base classes Reptile and Animal
/// </summary>
    public abstract class Snake : Reptile
    {
        public virtual bool Venemous { get; set; }
        public int Length { get; set; }
        //below is an override property ScalesType that is set to the string "slimy"
        public override string ScalesType { get; set; } = "slimy";

        /// <summary>
        /// below is a private method that returns a integer when run. It is only available to itself.
        /// </summary>
        /// <returns>integer with value of 5</returns>
        private int Slither()
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
