using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class SwordFactory : WarriorFactory
    {
        public override List<IElf> CreateElf(int number)
        {
            List<IElf> elves = new List<IElf>();
            for(int i = 0; i< number; i++)
            {
                elves.Add(new SwordElf());
            }
            return elves;
        }

        public override List<IOgre> CreateOgre(int number)
        {
            List<IOgre> ogres = new List<IOgre>();
            for (int i = 0; i < number; i++)
            {
                ogres.Add(new SwordOgre());
            }
            return ogres;
        }

      
    }
}
