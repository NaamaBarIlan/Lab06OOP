using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{/// <summary>
/// below is the creation of the method CongoLion, which also inherits information from the base classes Mammal and Animal
/// </summary>
    public class CongoLion : Mammal
    {
        public int PrideSize { get; set; }

        public bool HasMane { get; set; }
        //below is an override property HairType that is set to the string "shaggy"
        public override string HairType { get; set; } = "shaggy";
        //below is an override property Size that is set to the integer 500.9
        public override double Size => 500.9;

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Roar"</returns>
        public string Roar()
        {
            string RoarString = "Roar";
            return RoarString;
        }
        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Roar"</returns>

        public string Hunt()
        {
            string HuntString = "Hunting";
            return HuntString;
        }
    }
}
