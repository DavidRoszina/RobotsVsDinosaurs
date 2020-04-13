using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Herd
    {
        public string name;
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;

        public Herd(string name)
        {
            dino1 = new Dinosaur("T-Rex");
            dino2 = new Dinosaur("Stegasaurus");
            dino3 = new Dinosaur("Triceratops");
        }
    }
}
