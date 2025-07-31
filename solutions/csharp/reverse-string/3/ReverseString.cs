using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var reverseInput = input.Reverse();
        var joinArray = string.Concat(reverseInput);
        return joinArray;
    }
}