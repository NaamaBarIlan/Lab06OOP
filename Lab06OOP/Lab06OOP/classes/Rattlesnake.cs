using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{/// <summary>
/// below is a class that inherits info from the base classes Snake, Reptile, and Animal
/// </summary>
    public class Rattlesnake : Snake
    { /// <summary>
      /// below is a method that returns a string when run
      /// </summary>
      /// <returns>string</returns>
        public string Habitat { get; set; }
        
        public string Rattle()
        {
            string RattleString = "Rattle";
            return RattleString;
        }
    }
}
