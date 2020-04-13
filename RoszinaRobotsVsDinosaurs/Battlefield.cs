using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Battlefield
    {

        public string name;
        public Fleet battleFleet;
        public Herd battleHerd;
        public Battlefield(string name)
        {
            battleFleet = new Fleet("Cylons");
            battleHerd = new Herd("Dino Rampage");
        }
    }
}
