using System;

namespace Aula92TimeSpanOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan Operations
            Console.WriteLine("|---- TimeSpan Operations ----|");

            TimeSpan t1 = new TimeSpan(1, 30, 10); //Hours, minutes, seconds
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine("\nTimeSpan time 1 = "+ t1);
            Console.WriteLine("TimeSpan time 2 = "+ t2);
            Console.WriteLine("\n\nTime1 + Time2 = " + sum);
            Console.WriteLine("Time1 - Time2 = " + dif);
            Console.WriteLine("Time2 * 2.0 = " + mult);
            Console.WriteLine("Time2 / 2.0 = " + div);


            //TimeSpan Properties
            Console.WriteLine("\n|---- TimeSpan Properties ----|");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11); //(day, hour, minutes, seconds, milliseconds)
            Console.WriteLine(t);
            Console.WriteLine("\nDays: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds); Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours); 
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); 
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); 
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);



            //MaxValue, MinValue and ZeroValue
            TimeSpan maxValue = TimeSpan.MaxValue;
            TimeSpan minValue = TimeSpan.MinValue; //TimeSpan can be negative.
            TimeSpan zeroValue = TimeSpan.Zero;
            Console.WriteLine("\n\nThe Max value of TimeSpan is: " + maxValue);
            Console.WriteLine("The Min value of TimeSpan is: " + minValue);
            Console.WriteLine("Zero Value = " + zeroValue);
        }
    }
}
/*
 * Construtores 
    • TimeSpan() 
    • TimeSpan(ticks) 
    • TimeSpan(horas, minutos, segundos) 
    • TimeSpan(dias, horas, minutos, segundos) 
    • TimeSpan(dias, horas, minutos, segundos, milissegundos)
*/