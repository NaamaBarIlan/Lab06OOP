using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{/// <summary>
/// below is the creation of a class that inherits from the base classes Reptile and Animal
/// </summary>
    public class MonitorLizard : Reptile
    {
        public bool WaterWalk { get; set; }
        public int TongueLength { get; set; }

        /// <summary>
        /// below is a method that returns an integer when run
        /// </summary>
        /// <returns>integer</returns>
        public int GrowTail()
        {
            return 2;
        }

        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>integer</returns>
        public int ExtendTongue()
        {
            return 10;
        }
    }
}

