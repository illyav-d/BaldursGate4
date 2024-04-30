namespace GitGate4.Logger
{
    public class ConsoleLogger : IConsoleLogger
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayError(string message)
        {
            throw new Exception(message);
        }

    }
}
