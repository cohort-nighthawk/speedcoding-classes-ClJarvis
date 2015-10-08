using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Boat : Vehicle
    {
        public int NumOfWheels { get { return 0; }}

        String Horn()
        {
            return "honk";
        }
      
    }
        
}
