/*
 *  C# Program to Calculate Period Duration
 */

using System;

namespace period_duration
{
    class CompareDates
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime yesterday = today - new TimeSpan(1, 0, 0, 0);
            DateTime tomorrow = today + new TimeSpan(1, 0, 0, 0);
            Console.WriteLine("Yesterday was     {0}", yesterday);
            Console.WriteLine("Today     is      {0}", today);
            Console.WriteLine("Tomorrow  will be {0}", tomorrow);
            Console.WriteLine("\nIs yesterday less than today?   {0}.",
               yesterday < today);
            Console.WriteLine("Is today the same as tomorrow ? {0}.",
               today == tomorrow);

            TimeSpan totalTimespan = new TimeSpan(3, 5, 24, 17) +
                                     new TimeSpan(1, 18, 35, 43);
            Console.WriteLine(
               "\nThe length of the period is {0} days {1} hours" +
               " {2} minutes {3} seconds.",
               totalTimespan.Days, totalTimespan.Hours,
               totalTimespan.Minutes, totalTimespan.Seconds);
            Console.ReadLine();
        }
    }
}
