using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoszinaRobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield thing = new Battlefield("Kobol");
            
            thing.RunBattle();
            Console.ReadLine();
        }
    } 
}
