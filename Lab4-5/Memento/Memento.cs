using System.Collections.Generic;

namespace Game
{
    class ImprovedSwordOgreMemento
    {
        public int HitPoints { get; private set;}
        public int Damage { get; private set;}
        public ImprovedSwordOgreMemento(int hitPoints, int damage)
        {
            this.HitPoints = hitPoints;
            this.Damage = damage;
        }
    }
 
    // Caretaker
    class GameHistory
    {
        public Stack<ImprovedSwordOgreMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<ImprovedSwordOgreMemento>();
        }
    }
}