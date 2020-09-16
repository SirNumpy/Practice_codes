using System;
using System.Diagnostics.CodeAnalysis;

namespace DateTimeE
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime;
            DateTime datetime1;
            DateTime now = DateTime.Now;
            DateTime birthDay = new DateTime(2020, 09, 28);
           string input= Console.ReadLine();
            if(DateTime.TryParse(input,out datetime))
            {
                datetime1 = datetime;
                TimeSpan dayselapsed = now.Subtract(datetime1);
                Console.WriteLine(dayselapsed.Days);
            }
            
            Console.WriteLine(now);
            
        }
      
    }
}
