using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_OOP.classes
{
    public class MonitorLizard : Reptile
    {
        public bool WaterWalk { get; set; }
        public int TongueLength { get; set; }

        public int GrowTail()
        {
            return 2;
        }

        public int ExtendTongue()
        {
            return 10;
        }
    }
}
