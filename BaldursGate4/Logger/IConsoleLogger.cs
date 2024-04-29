namespace BaldursGate4.Logger
{
    public interface IConsoleLogger
    {
        void DisplayError(string message);
        void DisplayMessage(string message);
    }
}