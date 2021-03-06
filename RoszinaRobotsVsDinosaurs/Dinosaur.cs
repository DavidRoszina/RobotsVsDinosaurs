﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Dinosaur
    {
        
        public int energy;
        public int health;
        public int attackPower;

        public Dinosaur(string type)
        {
            health = 100;
            energy = 10;
            attackPower = 10;
        }
        public void Attack(Robot robotToAttack)
        {
            if (health > 0)
                robotToAttack.health -= attackPower;
        }
    }
}
