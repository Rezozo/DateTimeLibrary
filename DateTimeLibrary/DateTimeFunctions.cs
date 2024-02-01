using System;

namespace DateTimeLibrary
{
    public class DateTimeFunctions
    {
        public static TimeSpan CalculateDateDiffrence(DateTime dt1, DateTime dt2)
        {
            return (dt2 - dt1).Duration();
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }

                return true;
            }

            return false;
        }

        public static string GetTimeOfDay(DateTime dt)
        {
            int hour = dt.Hour;
            if (hour >= 6 && hour < 12)
            {
                return "Утро";
            } else if (hour >= 12 && hour < 18)
            {
                return "День";
            } else if (hour >= 18 && hour < 24)
            {
                return "Вечер";
            }
            return "Ночь";
        }

        public static string FormatDateTime(DateTime dt, string format)
        {
            return dt.ToString(format);
        }
    }
}
