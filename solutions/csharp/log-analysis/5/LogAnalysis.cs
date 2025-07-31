using System;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);

        if (index > -1)
        {
            int indexStr = index + delimiter.Length;
            return str.Substring(indexStr);
        }
        else
        {
            return string.Empty;
        }    
    }

    public static string SubstringBetween (this string str, string firstDelimiter, string secondDelimiter)
    {
        int index1 = str.IndexOf(firstDelimiter);
        int index2 = str.IndexOf(secondDelimiter, index1 + firstDelimiter.Length);

        if (!str.Contains(firstDelimiter) || !str.Contains(secondDelimiter))
        {
            return string.Empty;
        }
        else
        {
            return str.Substring(index1 + firstDelimiter.Length, index2 - (index1 + firstDelimiter.Length));
        }    
    }
    
    public static string Message (this string msg) => msg.SubstringAfter(": ");

    public static string LogLevel (this string level) => level.SubstringBetween("[", "]");
}