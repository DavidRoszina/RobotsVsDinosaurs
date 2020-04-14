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
            
            Console.WriteLine("Welcome to Robots vs. Dinosaurs!");
            Console.WriteLine("The Cylons are a Fleet of 3 Robots.");
            Console.WriteLine("Dino Rampage is a Herd of 3 Dinosaurs.");
            while (battleFleet.isAlive() && battleHerd.isAlive())
            {
                Console.WriteLine("Starting round");
                for (int i = 0; i < battleFleet.theRobots.Count; i++)
                {
                    battleFleet.theRobots[i].Attack(battleHerd.theDinos[i]);
                }
                for (int j = 0; j < battleHerd.theDinos.Count; j++)
                {
                    battleHerd.theDinos[j].Attack(battleFleet.theRobots[j]);
                }
            }
            if (battleFleet.isAlive())
            {
                Console.WriteLine("The Robots Win!");
            }    
            else if (battleHerd.isAlive())
            {
                Console.WriteLine("The Dinosaurs Win!");
            }
            else
            {
                Console.WriteLine("You are all dead. Ya'll caught The 'Rona.");
            }
        }
        
    }
}
