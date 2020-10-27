using System;

namespace CSharpTest
{
    public class IncorrectDataExceptionHandler : IExceptionHandler
    {
        public void ExitProgram()
        {
            Console.WriteLine("Incorrect data - please, check data file for errors and try again");
            System.Environment.Exit(1);
        }
    }
}