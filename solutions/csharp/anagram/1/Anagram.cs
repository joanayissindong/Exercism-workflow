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
        sortedWord = new string([.. baseWord.OrderBy(c => c)]);
    }

    public string[] FindAnagrams(string[] potentialMatches) => 
    [.. potentialMatches.Where
        (
            w => !w.Equals(baseWord, StringComparison.OrdinalIgnoreCase) 
            && new string([.. w.OrderBy(c => c)]) == sortedWord
        )
    ];
}