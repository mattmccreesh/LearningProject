using System;
using System.IO;
using System.Threading;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("start.txt", $"Container started at {DateTime.UtcNow}! Resting for a few minutes and then fetching id.");
            Thread.Sleep(300000);
            string conatinerId = Environment.GetEnvironmentVariable("HOSTNAME");
            File.WriteAllText("end.txt", $"Conatiner with id {conatinerId} ended at {DateTime.UtcNow}! Sleeping for about the next 5 hours before app terminates");
            int timeToSleep = 18000000; // 5 hours in ms
            Random rand = new Random();
            timeToSleep += rand.Next(-1800000, 1800000); // +- 30 minutes
            Thread.Sleep(timeToSleep);
        }
    }
}
