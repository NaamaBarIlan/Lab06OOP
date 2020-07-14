using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{/// <summary>
/// below is the creation of a class that inherits info from the base classes Mammal and Animal
/// </summary>
        public class Okapi : Mammal
    {
        public string LegsColor { get; set; }
        public bool HasKids { get; set; }
        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "Run"</returns>

        public string Run()
        {
            string RunString = "Run";
            return RunString;
        }

        /// <summary>
        /// below is a method that returns a string when run
        /// </summary>
        /// <returns>string with value of "NAAAW PET THE CUTE OKAPI!!!"</returns>
        public string Pet()
        {
            string PetString = "NAAAW PET THE CUTE OKAPI!!!";
            return PetString;
        }
    }
}

