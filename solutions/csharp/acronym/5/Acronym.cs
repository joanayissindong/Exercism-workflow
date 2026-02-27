using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        // Remove special characters unless they are hyphens
        string pattern = @"[^\w\s-]";
        string replacement = "";
        phrase = Regex.Replace(phrase, pattern, replacement);

        // Split the phrase into words
        string[] words = phrase.Split([" ", "-", "_"], StringSplitOptions.RemoveEmptyEntries);

        // Create an empty string to store the acronym
        string acronym = "";

        // Iterate through the words and add the first letter of each word to the acronym
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                acronym += word[0].ToString();
            }
        }

        // Return the acronym
        return acronym.ToUpper();
    }
}