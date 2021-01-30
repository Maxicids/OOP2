using System;
using System.Collections.Generic;
using System.Data;

namespace Game
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
    class Attack : IObservable
    {
        private AttackInfo attackInfo;
        private List<IObserver> observers;
        public Attack()
        {
            observers = new List<IObserver>();
            attackInfo = new AttackInfo();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
     
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
     
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(attackInfo);
            }
        }

        public void UpdateStatus()
        {
            Random rnd = new Random();
            attackInfo.AttackOfDivisions = rnd.Next(20, 30);
            NotifyObservers();
        }
    }

    class AttackInfo
    {
        public int AttackOfDivisions { get; set; }
    }
    interface IObserver
    {
        void Update(AttackInfo attackInfo);
    }
    class Defender : IObserver
    {
        private IObservable attack;
        private int HitPoints;

        public Defender(int hitPoints, IObservable attack)
        {
            this.HitPoints = hitPoints;
            this.attack = attack;
        }
        public void Update(AttackInfo attackInfo)
        {
            if (attackInfo.AttackOfDivisions > HitPoints)
            {
                Console.WriteLine("The defense has failed" + 
                                  " Hitpoints: " + HitPoints + " Attack: " + attackInfo.AttackOfDivisions);
            }
            else
            {
                Console.WriteLine("The defense has not failed" + 
                                  " Hitpoints: " + HitPoints + " Attack: " + attackInfo.AttackOfDivisions);
            }
        }
    }
}