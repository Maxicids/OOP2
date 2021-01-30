using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class WarriorFactory
    {
        public abstract List<IOgre> CreateOgre(int number);
        public abstract List<IElf> CreateElf(int number);

        //public List<IWarrior> CreatePerfomer(WarriorType warriorType,int number)
        //{
        //    switch (warriorType)
        //    {
        //        case WarriorType.Elf: return CreateElf(number);
        //            break;
        //        case WarriorType.Ogre: CreateOgre(number);
        //            break;
        //        default: throw new NotFindNeedWarriorException("Not find");
                    
        //    }
        //}
    }
}
