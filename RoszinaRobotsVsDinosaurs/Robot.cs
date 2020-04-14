using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Robot
    {
        
        public Weapon weapon;
        public int health;
        public int powerLevel;

        public Robot(string name)
        {
            weapon = new Weapon();
            health = 100;
            powerLevel = 10;
        }
        public void Attack(Dinosaur dinoToAttack)
        {
            
            if (health > 0)
                dinoToAttack.health -= weapon.weaponDamage;
            
            
        }
    }
}
