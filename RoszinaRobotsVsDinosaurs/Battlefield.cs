using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Battlefield
    {
        public Fleet battleFleet;
        public Herd battleHerd;
        public Battlefield(string name)
        {
            battleFleet = new Fleet("Cylons");
            battleHerd = new Herd("Dino Rampage");
        }

        
        
        public void RunBattle()
        {
            {
                Console.WriteLine("Welcome to Robots vs. Dinosaurs!");
                Console.WriteLine("The Cylons are a Fleet of 3 Robots.");
                Console.WriteLine("Dino Rampage is a Herd of 3 Dinosaurs.");


                for (int i = 0; i < battleFleet.theRobots.Count; i++)
                {
                    battleFleet.theRobots[i].Attack(battleHerd.theDinos[i]);

                }
                for (int j = 0; j < battleHerd.theDinos.Count; j++)
                {
                    battleHerd.theDinos[j].Attack(battleFleet.theRobots[j]);

                }
                //battleFleet.robot1.health -= battleHerd.dino1.attackPower;
            }

          
        }
    }
}
