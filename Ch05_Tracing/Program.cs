using System;
using System.Diagnostics;
using static System.Console;


namespace Ch05_Tracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Debug says Hello!");
            Trace.WriteLine("Trace says Hello!");
            WriteLine("Press ENTER to close.");
            ReadLine();
        }
    }
}
