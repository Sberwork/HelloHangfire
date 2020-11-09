using System;

namespace HangfireDemo
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            Console.WriteLine($"Hanfire recurring job!");
        }
    }
}