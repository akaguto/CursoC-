using System;

namespace Aula90TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan represent a Duration

            TimeSpan tS1 = new TimeSpan(); // 00:00:00
            TimeSpan tS2 = new TimeSpan(900000000L); // 00:01:30    - 900.000.000 ticks
            TimeSpan tS3 = new TimeSpan(2, 11, 21); // 02:11:21     - HH:MM:SS
            TimeSpan tS4 = new TimeSpan(1, 2, 11, 21); //1.02:11:21 - dd.HH:MM:SS

            Console.WriteLine(tS1);
            Console.WriteLine(tS2);
            Console.WriteLine(tS3);
            Console.WriteLine(tS4);

            //Methods From

            TimeSpan t1 = TimeSpan.FromDays(1.5); //creates a timespan equivalent to 1.5 days
            Console.WriteLine("TimeSpan equivalent to 1.5 days: " + t1);

            TimeSpan t2 = TimeSpan.FromHours(1.5); //creates a timespan equivalent to 1.5 hours
            Console.WriteLine("TimeSpan equivalent to 1.5 Hours: " + t2);

            TimeSpan t3 = TimeSpan.FromMinutes(1.5); //creates a timespan equivalent to 1.5 minutes
            Console.WriteLine("TimeSpan equivalent to 1.5 Minutes: " + t3);

            TimeSpan t4 = TimeSpan.FromSeconds(1.5); //creates a timespan equivalent to 1.5 seconds
            Console.WriteLine("TimeSpan equivalent to 1.5 Seconds: " + t4);

            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5); //creates a timespan equivalent to 1.5 Milliseconds
            Console.WriteLine("TimeSpan equivalent to 1.5 Milliseconds: " + t5);

            TimeSpan t6 = TimeSpan.FromTicks(900000000L); //creates a timespan equivalent to 900.000.000 ticks
            Console.WriteLine("TimeSpan equivalent to 900.000.000 ticks: " + t6);
        }
    }
}
