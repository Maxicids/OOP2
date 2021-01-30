using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal interface IObjectState
    {
        void HandleInput(MyObject hero, Input input);
        void Update(MyObject hero);
    }
    internal class MovingForward : IObjectState
    {
        public void HandleInput(MyObject hero, Input input)
        {
            if (input.GetKey() == "W")
            {
                hero.ObjectState = new MovingForward();
            }
        }

        public void Update(MyObject hero)
        {
            Console.WriteLine("MovingForward");
        }
    }
    internal class Jumping : IObjectState
    {
        public void HandleInput(MyObject hero, Input input)
        {
            if (input.GetKey() == "Spacebar")
            {
                hero.ObjectState = new Jumping();
            }
        }

        public void Update(MyObject hero)
        {
            Console.WriteLine("Jumping");
        }
    }
    internal class Staying : IObjectState
    {
        public void HandleInput(MyObject hero, Input input)
        {
            if (input.GetKey() == "")
            {
                hero.ObjectState = new Staying();
            }
        }

        public void Update(MyObject hero)
        {
            Console.WriteLine("Staying");
        }
    }

    // Context - объект, поведение которого динамически изменяется
    class MyObject
    {
        public IObjectState ObjectState { get; set; }
        public MyObject()
        {
            this.ObjectState = new Staying();
        }

        public MyObject(IObjectState objectState)
        {
            this.ObjectState = objectState;
        }

        public void SetObjectSTate(IObjectState objectState)
        {
            this.ObjectState = objectState;
        }
        public void HandleRequest(Input input)
        {
            this.ObjectState.HandleInput(this, input);
        }
        public void GetObjectStatus()
        {
            Console.WriteLine(this.ObjectState.ToString());
        }
        public void UpdateRequest()
        {
            this.ObjectState.Update(this);
        }
    }
    class Input
    {
        public ConsoleKeyInfo KeyInfo { get; private set; }

        public Input(ConsoleKeyInfo key)
        {
            this.KeyInfo = key;
        }

        public string GetKey()
        {
            return this.KeyInfo.Key.ToString();
        }
    }
}
