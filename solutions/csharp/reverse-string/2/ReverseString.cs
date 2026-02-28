using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        // var reverseInput = input.Reverse();
        // var joinArray = string.Concat(reverseInput);
        // return joinArray;
         var splitInput = input.Split("");
        var reverseInput = splitInput.Reverse();
        var joinInput = string.Join("", reverseInput);
        return joinInput;
    }
}