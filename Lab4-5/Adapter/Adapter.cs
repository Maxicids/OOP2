using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Adapter : ImprovedSwordElf
    {
        private SwordElf swordElf;
        public Adapter(SwordElf swordElf)
        {
            this.swordElf = swordElf;
        }
        public override void Function()
        {
            swordElf.Function();
        }
    }
}
