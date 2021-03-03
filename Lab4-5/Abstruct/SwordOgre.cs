using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class SwordOgre : IOgre
    {
        public int HitPoints => 45;
    }

    public class ImprovedSwordOgre // Originator
    {
        public int HitPoints = 50;
        public int Damage = 18;

        public void Injure()
        {
            HitPoints = HitPoints - 5;
            Damage = Damage - 2;
        }
    }

}
