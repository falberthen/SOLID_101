using System;

namespace SOLID_101.Services
{
    /// <summary>
    /// Writing service implemementation for Console
    /// </summary>
    public class ConsoleWritingService : IWritingService
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message = "")
        {
            Console.WriteLine(message);
        }
    }
}
