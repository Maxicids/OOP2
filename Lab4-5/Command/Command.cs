using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ICommand
    {
        public void Execute();
        public void Undo();
    }
    class JumpCommand : ICommand
    {
        Receiver receiver;
        public JumpCommand(Receiver r)
        {
            receiver = r;
        }
        public void Execute()
        {
            receiver.Jump();
        }

        public void Undo()
        { }
    }
    class FireCommand : ICommand
    {
        Receiver receiver;
        public FireCommand(Receiver r)
        {
            receiver = r;
        }
        public void Execute()
        {
            receiver.Fire();
        }

        public void Undo()
        { }
    }

    // получатель команды
    class Receiver
    {
        public void Fire()
        {
            Console.WriteLine("You have fired");
        }
        public void Jump ()
        {
            Console.WriteLine("You have jumped");
        }
    }
    // инициатор команды
    class Invoker
    {
        ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
}
