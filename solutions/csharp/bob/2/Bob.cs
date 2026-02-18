using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.EndsWith('?')) 
            return "Sure.";
        if (statement == statement.ToUpper() && statement.Any(char.IsLetter)) 
            return "Whoa, chill out!";
        if (statement == statement.ToUpper() && statement.EndsWith('?')) 
            return "Calm down, I know what I'm doing!";
        return string.IsNullOrWhiteSpace(statement) ? "Fine. Be that way!" : "Whatever.";
    }
}