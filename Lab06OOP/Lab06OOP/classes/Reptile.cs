using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{
    public abstract class Reptile : Animal
    {
        public bool BloodType { get; set; }

        public string ScalesType { get; set; }

        public int LayEgg()
        {
            return 5;
        }

        public string Shed()
        {
            string ShedString = "It shed it's skin";
            return ShedString;
        }
    }
}
