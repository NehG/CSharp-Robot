using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RobotLog
    {
        public static ArrayList DirectionLogger = new ArrayList();
        public static int Distance;

        public String LogDirections
        {
            get
            {
                return DirectionLogger.ToString();
            }
            set
            {
                DirectionLogger.Add(value);
                Console.WriteLine(value);

            }

        }

        public int LogDistance
        {
            get
            {
                return Distance;
            }
            set=>Distance = Distance + value;
        }

    }
}
