using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ' || word[i] == '-')
            {
                continue;
            }
            for (int j = i + 1; j <word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
