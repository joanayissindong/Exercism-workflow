using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim(); // delete leading and trailing whitespaces

        if (string.IsNullOrWhiteSpace(statement)) // for whitespace only
            return "Fine. Be that way!";

        if (statement == statement.ToUpper() && statement.EndsWith('?') && statement.Any(char.IsLetter)) // for shouting question
            return "Calm down, I know what I'm doing!";

        if (statement.EndsWith('?')) // for question only
            return "Sure.";

        if (statement == statement.ToUpper() && statement.Any(char.IsLetter)) // for shouting only
            return "Whoa, chill out!";

        return "Whatever."; // default answer
    }
}