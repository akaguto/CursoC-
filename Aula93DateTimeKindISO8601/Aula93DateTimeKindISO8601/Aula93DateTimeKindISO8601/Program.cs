using System;

namespace Aula93DateTimeKindISO8601
{
    class Program
    {
        /*
        DateTimeKind and ISO 8601
        
        Convention: 
            Store in UTC(GMT) and show in Local time.
            To convert a DateTime to Local or UTC, use:
                myDate.ToLocalTime();
                myDate.To.UniversalTime();
        */
        static void Main(string[] args)
        {
            //---- DateTimeKind ---- //
            //Define Valores possíveis para a Localidade da data: Local, utc, unspecified

            Console.WriteLine("|--- DateTimeKind ---|"); 
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("\n- Local:");
            Console.WriteLine("date1: " + d1);
            Console.WriteLine("date1 Kind: " + d1.Kind); //Kind of d1 is Local.
            Console.WriteLine("date1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("date1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine("\n- UTC:");
            Console.WriteLine("date2: " + d2);
            Console.WriteLine("date2 Kind: " + d2.Kind); //Kind of date2 is UTC.
            Console.WriteLine("date2 to Local: " + d2.ToLocalTime()); 
            Console.WriteLine("date2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine("\n- Unspecified:");
            Console.WriteLine("date3: " + d3); //Kind of d3 is Unspecified.
            Console.WriteLine("date3 Kind: " + d3.Kind);
            Console.WriteLine("date3 to Local: " + d3.ToLocalTime()); // -3
            Console.WriteLine("date3 to Utc: " + d3.ToUniversalTime()); // +3


            //---- ISO 8601 ---- //
            
            /*
             *https://www.iso.org/iso-8601-date-and-time-format.html 
             *https://en.wikipedia.org/wiki/ISO_8601 
            
             *Format: 
             *yyyy-MM-ddTHH:mm:ssZ  - Letter Z means date/hour is an string UTC.
            */

            Console.WriteLine("\n\n|--- ISO 8601 ---|");

            DateTime date1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime date2 = DateTime.Parse("2000-08-15T13:05:58Z"); // <==== ISO 8601. ***create a kind:local DateTime  !!!!!! 

            Console.WriteLine("date1: " + date1);
            Console.WriteLine("date1 Kind: " + date1.Kind);
            Console.WriteLine("date1 to Local: " + date1.ToLocalTime());
            Console.WriteLine("date1 to Utc: " + date1.ToUniversalTime());
            Console.WriteLine(); 
            Console.WriteLine("date2: " + date2);
            Console.WriteLine("date2 Kind: " + date2.Kind);
            Console.WriteLine("date2 to Local: " + date2.ToLocalTime());
            Console.WriteLine("date2 to Utc: " + date2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(date2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // careful! use the mask below. You can have a trouble using this option. 
            Console.WriteLine(date2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // <==== ISO 8601

        }
    }
}
