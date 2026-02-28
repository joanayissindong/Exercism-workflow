public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        if (value < 1 || value > 3999)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be in the range 1 - 3999");
        }

        var romanNumbers = new []
        {
            new { Value = 1000, Roman = "M" },
            new { Value = 900, Roman = "CM" },
            new { Value = 500, Roman = "D" },
            new { Value = 400, Roman = "CD" },
            new { Value = 100, Roman = "C" },
            new { Value = 90, Roman = "XC" },
            new { Value = 50, Roman = "L" },
            new { Value = 40, Roman = "XL" },
            new { Value = 10, Roman = "X" },
            new { Value = 9, Roman = "IX" },
            new { Value = 5, Roman = "V" },
            new { Value = 4, Roman = "IV" },
            new { Value = 1, Roman = "I" }
        };

        var result = string.Empty;
        foreach (var item in romanNumbers)
        {
            while (value >= item.Value)
            {
                result += item.Roman;
                value -= item.Value;
            }
        }

        return result;
    }
}