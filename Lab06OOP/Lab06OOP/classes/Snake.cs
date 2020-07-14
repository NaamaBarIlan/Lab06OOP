using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP
{
    public abstract class Snake : Reptile
    {
        public bool Venemous { get; set; }
        public int Length { get; set; }

        public int Slither()
        {
            return 5;
        }

        public string Bite()
        {
            string BiteString = "Ow";
            return BiteString;
        }
    }
}
