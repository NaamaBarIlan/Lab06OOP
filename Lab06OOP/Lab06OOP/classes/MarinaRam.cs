using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{
    public class MarinaRam : Mammal
    {
        public int HornLength { get; set; }
        public int LifeAltitude { get; set; }

        public string Ram()
        {
            string RamString = "Ram";
            return RamString;
        }

        public int Climb()
        {
            return 12000;
        }
    }
}
