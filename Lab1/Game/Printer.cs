using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Printer
    {
        public static void PrintWarrior(List<IElf> warriors)
        {
            int warriorsCount = warriors.Count;
            for (int i = 0; i < warriorsCount; i++)
            {
                Console.WriteLine("Warrior" + i + " " + warriors[i].GetType().Name + " has " + warriors[i].HitPoints+" hitpoints");
            }
        }
    }
}
