using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class Archer
    {
        public int Damage { get; private set; }


        public Archer(int damage)
        {
            this.Damage = damage;
        }
        public abstract Archer Clone();
    }

    class OgreArcher : Archer, IWarrior
    {
        public OgreArcher(int damage) : base(damage)
        { }

        public int HitPoints => 25;

        public override Archer Clone()
        {
            return new OgreArcher(Damage);
        }
    }

    class ElfArcher : Archer, IWarrior
    {
        public ElfArcher(int damage) : base(damage)
        { }

        public int HitPoints => 20;

        public override Archer Clone()
        {
            return new ElfArcher(Damage);
        }
    }
}
