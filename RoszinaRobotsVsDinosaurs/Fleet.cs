using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Fleet
    {
        
        public List<Robot> theRobots;

        public Fleet(string fleetName)
        {
            theRobots = new List<Robot>();
            theRobots.Add(new Robot("Steve"));
            theRobots.Add(new Robot("Jimmy"));
            theRobots.Add(new Robot("Johnny V"));

        }
    }
}
