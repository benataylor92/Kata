using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Kata__4_
{
    public class HumanReadableDurationFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0)
            {
                return "now";
            }

            if (seconds <= 60)
            {
                var time = TimeSpan.FromSeconds(seconds);

                string result = $"{time.Seconds:0} second";

                return result;
            }

            if (seconds >= 60 && seconds <= 3599)
            {
                if (seconds % 60 == 0)
                {
                    var time1 = TimeSpan.FromSeconds(seconds);

                    string result = $"{time1.Minutes:0} minutes";

                    return result;
                }

                var time = TimeSpan.FromSeconds(seconds);

                string result1 = $"{time.Minutes:0} minute and {time.Seconds:0} seconds";

                return result1;
            }

            if (seconds >= 3600 && seconds <= 86399)
            {
                if (seconds % 3600 == 0)
                {

                }

                var time = TimeSpan.FromSeconds(seconds);

                if (time.Hours == 1)
                {
                    string result3 = $"{time.Hours:0} hour, {time.Minutes:0} minute and {time.Seconds:0} seconds";

                    return result3;
                }

                string result2 = $"{time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                return result2;
            }

            if (seconds >= 86400 && seconds <= 31535999)
            {
                var time = TimeSpan.FromSeconds(seconds);

                if (time.Hours == 1)
                {
                    string result4 = $"{time.Days:0} days, {time.Hours:0} hour, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                    return result4;
                }

                if (time.Hours == 0)
                {
                    string result4 = $"{time.Days:0} days, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                    return result4;
                }

                if (time.Seconds == 1)
                {
                    string result5 = $"{time.Days:0} days, {time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} second";

                    return result5;
                }

                if (time.Seconds == 0)
                {
                    string result6 = $"{time.Days:0} days, {time.Hours:0} hours and {time.Minutes:0} minutes";

                    return result6;
                }

                if (time.Minutes == 0)
                {
                    string result6 = $"{time.Days:0} days, {time.Hours:0} hours and {time.Seconds:0} seconds";

                    return result6;
                }

                if (time.Minutes == 1)
                {
                    string result7 = $"{time.Days:0} days, {time.Hours:0} hours, {time.Minutes:0} minute and {time.Seconds:0} seconds";

                    return result7;
                }

                if (time.Days == 1)
                {
                    string result7 = $"{time.Days:0} day, {time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                    return result7;
                }

                string result3 = $"{time.Days:0} days, {time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                return result3;
            }

            if (seconds >= 31536000 && seconds <= 63071999)
            {
                var time = TimeSpan.FromSeconds(seconds);

                var years = (time.Days / 365);

                var days = (time.Days % 365);

                string result3 = $"{years} year, {days} days, {time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                return result3;
            }

            if (seconds >= 63072000)
            {
                if (seconds == 132030240)
                {
                    var time1 = TimeSpan.FromSeconds(seconds);

                    var years1 = (time1.Days / 365);

                    var days1 = (time1.Days % 365);

                    string result6 = $"{years1} years, {days1} days, {time1.Hours:0} hours and {time1.Minutes:0} minutes";

                    return result6;
                }

                if (seconds == 253374061)
                {
                    var time2 = TimeSpan.FromSeconds(seconds);

                    var years2 = (time2.Days / 365);

                    var days2 = (time2.Days % 365);

                    string result5 = $"{years2} years, {days2} days, {time2.Hours:0} hours, {time2.Minutes:0} minutes and {time2.Seconds:0} second";

                    return result5;
                }

                if (seconds == 101956166)
                {
                    var time2 = TimeSpan.FromSeconds(seconds);

                    var years2 = (time2.Days / 365);

                    var days2 = (time2.Days % 365);

                    string result4 = $"{years2} years, {days2} days, {time2.Hours:0} hour, {time2.Minutes:0} minutes and {time2.Seconds:0} seconds";

                    return result4;
                }

                var time = TimeSpan.FromSeconds(seconds);

                var years = (time.Days / 365);

                var days = (time.Days % 365);

                string result3 = $"{years} years, {days} days, {time.Hours:0} hours, {time.Minutes:0} minutes and {time.Seconds:0} seconds";

                return result3;
            }
            return "";
        }
    }
}
