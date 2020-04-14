using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Weapon
    {
        public int weaponDamage = 10;
        List<string> weapons = new List<string>() { "Lazer", "Drill", "Claw" };
        public string selectedWeapon;
        public Weapon()
        { 
            var random = new Random();
            int index = random.Next(weapons.Count);
            selectedWeapon = weapons[index];
        }
    }
}
