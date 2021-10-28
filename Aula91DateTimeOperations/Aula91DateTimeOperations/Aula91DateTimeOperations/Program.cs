using System;

namespace Aula91DateTimeOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime Operations
            Console.WriteLine("|---- DateTime Operations ----|");
            DateTime date = DateTime.Now;

            DateTime sumHours = date.AddHours(2);
            Console.WriteLine("\nsum 2 Hours: "+ sumHours);

            DateTime sumMinutes = date.AddMinutes(5);
            Console.WriteLine("sum 5 Minutes: " + sumMinutes);

            DateTime sumDays = date.AddDays(7);
            Console.WriteLine("sum 7 Days: " + sumDays);


            DateTime date1 = new DateTime(2021, 02, 07);
            DateTime date2 = new DateTime(2021, 02, 14);
            TimeSpan sub = date2.Subtract(date1);
            Console.WriteLine("\nDate 1 - date 2: " + sub);

            //Convert DateTime to String
            Console.WriteLine("\n|---- Convert ----|");
            DateTime d2 = new DateTime(2019, 11, 10, 9, 10, 45);

            string s1 = d2.ToLongDateString(); // Convert the value to a long date string. ex: Friday, October 11, 2019
            Console.WriteLine("\nLong date string: "+ s1); 

            string s2 = d2.ToLongTimeString(); // Time. ex: 09:10:45
            Console.WriteLine("Print time string: " + s2);

            string s3 = d2.ToShortDateString(); // Convert the value to a short date string. ex: 10/11/2019
            Console.WriteLine("Short date string: " + s3);

            string s4 = d2.ToShortTimeString(); // Short Time. Only hour and minute. ex: 09:10
            Console.WriteLine("Short Time string: " + s4);

            string s5 = d2.ToString(); // default: 10/11/2019 09:10:45
            Console.WriteLine("Default: Date and time: "+ s5);

            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss"); // format 
            Console.WriteLine("format default: date and time: "+ s6);

            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff"); // format with milliseconds 
            Console.WriteLine("format default: date and time with milliseconds: " + s7);


            // Properties
            Console.WriteLine("\n|---- Properties ----|");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("\n1 - Date(DateTime): " + d.Date);
            Console.WriteLine("2 - Day(int): " + d.Day);
            Console.WriteLine("3 - DayOfWeek(DayOfWeek): " + d.DayOfWeek);
            Console.WriteLine("4 - DayOfYear(int): " + d.DayOfYear);
            Console.WriteLine("5 - Hour(int): " + d.Hour);
            Console.WriteLine("6 - Kind(DateTimeKind): " + d.Kind);
            Console.WriteLine("7 - Millisecond(int): " + d.Millisecond);
            Console.WriteLine("8 - Minute(int): " + d.Minute);
            Console.WriteLine("9 - Second(int): " + d.Second);
            Console.WriteLine("10 - Month(int): " + d.Month);
            Console.WriteLine("11 - Ticks(long): " + d.Ticks);
            Console.WriteLine("12 - TimeOfDay(TimeSpan): " + d.TimeOfDay);
            Console.WriteLine("13 - Year(int): " + d.Year);
        }
    }
}

/*
- Operations: 
    • DateTime x = ... 
    • DateTime y = x.Add(timeSpan); 
    • DateTime y = x.AddDays(double); 
    • DateTime y = x.AddHours(double); 
    • DateTime y = x.AddMilliseconds(double); 
    • DateTime y = x.AddMinutes(double); 
    • DateTime y = x.AddMonths(int); 
    • DateTime y = x.AddSeconds(double); 
    • DateTime y = x.AddTicks(long); 
    • DateTime y = x.AddYears(int); 
    • DateTime y = x.Subtract(timeSpan); 
    • TimeSpan t = x.Subtract(dateTime);

*/