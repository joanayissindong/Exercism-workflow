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
            else if (count > 1)
            {
                encoded.Append(count);
            }
            encoded.Append(input[i]);
            count = 1;
        }
        return encoded.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        StringBuilder decoded = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            int count = 1;

            if (char.IsDigit(input[i]))
            {
                count = count * 10 + (input[i] - '0');
                decoded.Append(count);
            }
            else
            {
                decoded.Append(input[i]);
            }
        }
        return decoded.ToString();
    }
}
