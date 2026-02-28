using System;
using System.Text;
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
        string[] words = phrase.Split([' ', '-', '_'], StringSplitOptions.RemoveEmptyEntries);

        // Create an empty string to store the acronym
        StringBuilder acronym = new StringBuilder();

        // Iterate through the words and add the first letter of each word to the acronym
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                // Convert the first letter of the word to uppercase and append it to the acronym
                acronym.Append(char.ToUpper(word[0]));
            }
        }

        // Return the acronym
        return acronym.ToString();
    }
}