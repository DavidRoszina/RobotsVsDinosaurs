using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    
    class Fleet
    {
        public string fleetName;
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;

        public Fleet(string fleetName)
        {
            robot1 = new Robot("Steve");
            robot2 = new Robot("Jimmy");
            robot3 = new Robot("Johnny V");
        }
    }
}
