using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        while (year % 4 == 0 || year % 400 == 0)
        {
            return true;
        }
        return false;
    }
}