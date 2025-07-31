using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // A year is a leap year if it is divisible by 4, but not divisible by 100, unless it is also divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}