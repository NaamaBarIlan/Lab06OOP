using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{
        public class Okapi : Mammal
    {
        public string LegsColor { get; set; }
        public bool HasKids { get; set; }

        public string Run()
        {
            string RunString = "Run";
            return RunString;
        }

        public string Pet()
        {
            string PetString = "NAAAW PET THE CUTE OKAPI!!!";
            return PetString;
        }
    }
}
