using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{
     public abstract class Mammal : Animal
    {
        public bool BloodType { get; set; }
        public string HairType { get; set; }

        public string ProduceMilk()
        {
            string ProduceMilkString = "Produce Milk";
            return ProduceMilkString;
        }

        public int HasYoung()
        {
            return 0;
        }
    }

    

}
