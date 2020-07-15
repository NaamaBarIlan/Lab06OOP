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
        //below is an override property ScalesType that is set to the string "hard"
        public override string ScalesType { get; set; } = "hard";

        /// below is an override method inherited from the virtual method in the Reptile class that returns a integer when run
        /// </summary>
        /// <returns>integer with the new value of 2</returns>
        /// 
        public override int LayEgg()
        {
            return 2;
        }

        /// <summary>
        /// below is a method that returns an integer when run
        /// </summary>
        /// <returns>integer with value of 2</returns>
        public int GrowTail()
        {
            return 2;
        }

        /// <summary>
        /// below is a method that returns a integer when run
        /// </summary>
        /// <returns>integer with value of 10</returns>
        public int ExtendTongue()
        {
            return 10;
        }
    }
}

