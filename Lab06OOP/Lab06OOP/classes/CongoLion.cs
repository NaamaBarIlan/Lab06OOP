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
        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string</returns>
        public string Roar()
        {
            string RoarString = "Roar";
            return RoarString;
        }
        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string</returns>

        public string Hunt()
        {
            string HuntString = "Hunting";
            return HuntString;
        }
    }
}
