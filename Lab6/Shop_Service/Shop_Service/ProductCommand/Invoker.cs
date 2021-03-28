namespace Shop_Service.ProductCommand
{
    public class Invoker
    {
        private Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
    }
}