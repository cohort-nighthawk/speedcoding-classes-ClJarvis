using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Truck : Vehicle
    {
        public int NumOfWheels { get { return 4; } }

        String Horn()
        {
            return "honk";
        }
    }
}
