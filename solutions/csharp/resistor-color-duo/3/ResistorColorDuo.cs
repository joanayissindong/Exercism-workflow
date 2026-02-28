using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> s_colorValues = new Dictionary<string, int>()
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };
    public static int Value(string[] colors)
    {
        if (colors.Length >= 2)
        {
            int firstDigit = s_colorValues[colors[0].ToLower()];
            int secondDigit = s_colorValues[colors[1].ToLower()];
            return firstDigit * 10 + secondDigit;
        }
        else
        {
            throw new ArgumentException("Invalid number of colors: need 2 or more");
        }
    }
}
