using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class WarELfLord : IElf
    {
        private static WarELfLord instance;

        private WarELfLord()
        { }
        public int HitPoints => 150;

        public static WarELfLord getInstance()
        {
            if (instance == null)
            {
                instance = new WarELfLord();
            } 
            return instance;
        }
    }
}
