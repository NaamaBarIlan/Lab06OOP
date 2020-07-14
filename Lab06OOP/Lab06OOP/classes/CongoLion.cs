using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{
    public class CongoLion : Mammal
    {
        public int PrideSize { get; set; }

        public bool HasMane { get; set; }

        public string Roar()
        {
            string RoarString = "Roar";
            return RoarString;
        }

        public string Hunt()
        {
            string HuntString = "Hunting";
            return HuntString;
        }
    }
}
