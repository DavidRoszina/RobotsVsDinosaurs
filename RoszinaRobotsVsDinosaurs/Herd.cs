using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Herd
    {
        
        public List<Dinosaur> theDinos;

        public Herd(string name)
        {
            theDinos = new List<Dinosaur>();
            theDinos.Add(new Dinosaur("T-Rex"));
            theDinos.Add(new Dinosaur("Stegasaurus"));
            theDinos.Add(new Dinosaur("Triceratops"));
           
        }
        public bool isAlive()
        {
            for (int i = 0; i < theDinos.Count; i++)
            {
                if (theDinos[i].health > 0)
                    return true;
            }
            return false;
        }
    }
}
