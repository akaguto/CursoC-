using System;
using System.Globalization;

namespace Aula89DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Most Used Constructors
            DateTime d1 = new DateTime(2021, 10, 27); //date. time is 00:00:00.
            Console.WriteLine(d1);
            
            DateTime d2 = new DateTime(2021, 10, 27, 14, 45, 03); //date and time. 
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2021, 10, 27, 14, 45, 03, 500); //date and time with milliseconds
            Console.WriteLine(d3);

            //Most Used Builders
            DateTime date = DateTime.Now;  // Current Date & Time
            DateTime date2 = DateTime.Today;
            DateTime date3 = DateTime.UtcNow; // GMT time.
            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.WriteLine(date3);

            //Parse. Provide date & time

            DateTime dateParse = DateTime.Parse("2021-10-27"); //DataBase format. yyyy-MM-dd
            DateTime dateParse2 = DateTime.Parse("2021-10-27 14:59:50"); 
            DateTime dateParse3 = DateTime.Parse("27/10/2021");
            DateTime dateParse4 = DateTime.Parse("2021/10/27 15:00:00");

            Console.WriteLine("Date Parse 1: " + dateParse);
            Console.WriteLine("Date Parse 2: " + dateParse2);
            Console.WriteLine("Date Parse 3: " + dateParse3);
            Console.WriteLine("Date Parse 4: " + dateParse4);

            //ParseExact - Format Mask

            DateTime dateExact = DateTime.ParseExact("2021-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("1 - Date Parse Exact: " + dateParse);

            DateTime dateExact2 = DateTime.ParseExact("27/10/2021 15:08:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("2 - Date Parse Exact: " + dateParse);
        }
    }
}
