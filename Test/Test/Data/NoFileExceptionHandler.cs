using System;

namespace CSharpTest
{
    public class NoFileExceptionHandler : IExceptionHandler
    {
        public void ExitProgram()
        {
            Console.WriteLine("File does not exist. Try again");
            System.Environment.Exit(1);
        }
    }
}