using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.EndsWith('?')) 
        {
            if (statement == statement.ToUpper())
            {
                return "Calm down, I know what I'm doing!";
            }
            return "Sure.";
        }
        if (statement == statement.ToUpper()) 
            return "Whoa, chill out!";
        return string.IsNullOrWhiteSpace(statement) ? "Fine. Be that way!" : "Whatever.";
    }
}