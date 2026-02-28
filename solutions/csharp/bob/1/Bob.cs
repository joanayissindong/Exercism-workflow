using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.EndsWith('?')) 
            return "Sure.";
        else if (statement == statement.ToUpper() && statement.Any(char.IsLetter)) 
            return "Whoa, chill out!";
        else if (statement == statement.ToUpper() && statement.EndsWith('?')) 
            return "Calm down, I know what I'm doing!";
        else if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        else
            return "Whatever.";
    }
}