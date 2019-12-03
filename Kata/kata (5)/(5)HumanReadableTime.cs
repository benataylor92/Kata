using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.kata__5_
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            var result = TimeSpan.FromSeconds(seconds);

            var time1 = Math.Floor(result.TotalHours);

            string time = $"{time1:00}:{result.Minutes:00}:{result.Seconds:00}";

            return time;
        }
    }
}
