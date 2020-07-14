using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{
    public class Rattlesnake : Snake
    {
        public string Habitat { get; set; }
        
        public string Rattle()
        {
            string RattleString = "Rattle";
            return RattleString;
        }
    }
}
