using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GuardOgre : IOgre
    {
        public int HitPoints => 70;
        private int hp = 70;
        public Strategy strategy = new StrategyAttack();

        public void Damaged(int damage)
        {
            this.hp -= damage;
            if (this.hp < 50 && this.hp > 30)
            {
                this.strategy = new StrategyDefence();
            }
            if (this.hp < 30)
            {
                this.strategy = new StrategyRetriat();
            }
        }
        public void Execute()
        {
            strategy.Execute();
        }
    }
}
