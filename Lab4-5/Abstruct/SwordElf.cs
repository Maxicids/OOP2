using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class SwordElf : IElf
    {
        public int HitPoints => 35;

        public void Function()
        {
            Console.WriteLine("function");
        }
    }
    public class ImprovedSwordElf : IElf
    {
        public int HitPoints => 45;
        public virtual void Function()
        {
            Console.WriteLine("improved function");
        }
    }
}
