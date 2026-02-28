using System;
using System.Text;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if(string.IsNullOrEmpty(input)) return ""; 

        StringBuilder encoded = new StringBuilder();
        int count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i + 1 < input.Length && input[i] == input[i + 1])
            {
                count++;
            }
            else
            {
                if (count >= 1)
                {
                    encoded.Append(count);
                }
                encoded.Append(input[i]);
                count = 1;
            }
        }
        return encoded.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        StringBuilder decoded = new StringBuilder();

        int count = 0;

       foreach (char c in input)
       {
        
            if (char.IsDigit(c))
            {
                count = count * 10 + (c - '0'); // accumulate multi-digit numbers
            }
            else 
            {
                if (count > 0)
                {
                    // repeat the character count times
                    decoded.Append(c, count);
                    count = 0; // reset count
                }
                else
                {
                    decoded.Append(c);
                }
            }
       }
       return decoded.ToString();
    }
}
