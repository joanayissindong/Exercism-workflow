using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        char[] textArray = text.ToCharArray();

        for ( int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                // determine the offset based on the case of the letter
                char offset = char.IsUpper(text[i]) ? 'A' : 'a';

                // calculate the offset caracter
                textArray[i] = (char)((textArray[i] - offset + shiftKey) % 26 + offset);
            }
            else
            {
                textArray[i] = text[i];
            }
        }
        return new string(textArray);
    }
}