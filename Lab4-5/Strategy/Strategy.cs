using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface Strategy
    {
        void Execute();
    }

    public class StrategyDefence : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("Defending");
        }
    }

    public class StrategyAttack : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("Attacking");
        }
    }

    public class StrategyRetriat : Strategy
    {
        public void Execute()
        {
            Console.WriteLine("Retriating");
        }
    }
}
