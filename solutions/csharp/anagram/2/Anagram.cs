using System;
using System.Linq;

public class Anagram
{
    private readonly string baseWord;
    private readonly string sortedWord;
    public Anagram(string baseWord)
    {
        // word in lowercase
        this.baseWord = baseWord.ToLower();

        // verify the same nomber of characters
        sortedWord = new string([.. this.baseWord.OrderBy(c => c)]);
    }

    public string[] FindAnagrams(string[] potentialMatches) => [.. potentialMatches.Where(IsAnagram)];
    private bool IsAnagram(string arg) 
    {
        // word in lowercase
        arg = arg.ToLower();

        // verify the same nomber of characters
        return !arg.Equals(baseWord, StringComparison.OrdinalIgnoreCase) && SortedLetters(arg) == sortedWord;
    }

    private string SortedLetters(string w) 
    {
        _ = new string([.. w.OrderBy(c => c)]);
        return w;
    }
}