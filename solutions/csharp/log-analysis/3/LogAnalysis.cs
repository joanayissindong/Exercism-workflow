using System;
using System.Linq;

public static class LogAnalysis 
{
    static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);

        if (str.Contains(delimiter))
        {
            int indexStr = index + delimiter.Length;
            return str.Substring(indexStr);
        }
        else
        {
            return GetEmpty();
        }    
    }


    static string SubstringBetween (this string str, string firstDelimiter, string secondDelimiter)
    {
        int index1 = str.IndexOf(firstDelimiter);
        int index2 = str.IndexOf(secondDelimiter, index1 + firstDelimiter.Length);

        if (!str.Contains(firstDelimiter) || !str.Contains(secondDelimiter))
        {
            return GetEmpty();
        }
        else
        {
            return str.Substring(index1 + firstDelimiter.Length, index2 - (index1 + firstDelimiter.Length));
        }    
    }
    
    static string Message (this string msg)
    {
        return msg.SubstringAfter(": ");
    }

    static string LogLevel (this string level)
    {
        return level.SubstringBetween("[", "]");
    }


    private static string GetEmpty()
    {
        return string.Empty;
    }
}