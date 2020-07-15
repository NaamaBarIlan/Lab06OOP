using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{/// <summary>
/// below is the creation of the abstract class Animal
/// </summary>
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public virtual double Size { get; set; }

        /// <summary>
        /// below is an abstract method that returns a string when GetFed is run
        /// </summary>
        /// <returns>string with value determined by derived classes</returns>
        public abstract string GetFed();


        /// <summary>
        /// below is a method that returns a string when GetSleep is run
        /// </summary>
        /// <returns>string with value determined by derived classes</returns>
        public abstract string GetSleep();       
    }

   
}
