using System;
using System.Text;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if(string.IsNullOrEmpty(input)) return ""; 

        StringBuilder encoded = new StringBuilder();
        int count = 1;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                count++;
            }
            else
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

        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            count = count * 10 + input[i] - '0';
            
            while (char.IsDigit(input[i]))
            {
                decoded.Append(count);
            }
            decoded.Append(input[i]);
        }
        return decoded.ToString();
    }
}