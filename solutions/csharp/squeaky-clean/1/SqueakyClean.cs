using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier)) return identifier;
        
        StringBuilder result = new StringBuilder();
        bool capitalize = false;

        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else if (c == ' ')
            {
                result.Append("_");
            }
            else if (c == '-')
            {
                capitalize = true;
            }
            else if (char.IsLetter(c))
            {
                if (IsGreekLowerCase(c)) continue;
                if (capitalize)
                {
                    result.Append(char.ToUpper(c));
                    capitalize = true;
                }
                else
                {
                    result.Append(c);
                }
            }
        }
        return result.ToString();
    }

    private static bool IsGreekLowerCase(char c)
    {
        return c >= 'α' && c <= 'ω';
    }
}
