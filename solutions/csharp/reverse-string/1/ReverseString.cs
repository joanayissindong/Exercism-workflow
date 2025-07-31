using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var splitInput = input.Split("");
        var reverseInput = splitInput.Reverse();
        var joinInput = string.Join("", reverseInput);
        return joinInput;
    }
}