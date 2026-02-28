using System.Text;

public static class BottleSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        if (startBottles <= 0 || takeDown <= 0) return "Invalid input";

        StringBuilder lyrics = new StringBuilder();

        for (int i = startBottles; i > startBottles - takeDown; i --)
        {
            if (i > 0)
            {
                lyrics.AppendLine($"{i} green bottles hanging on the wall,");
                lyrics.AppendLine($"{i} green bottles hanging on the wall,");
                lyrics.AppendLine("And if one green bottle should accidentally fall,");

                int remaining = i - 1;
                string remainingText = remaining > 0 ? $"{remaining} green bottles" : "no green bottles";
                lyrics.AppendLine($"There'll be {remainingText.ToLower()} hanging on the wall.");
                lyrics.AppendLine();
            }
        }
        return lyrics.ToString();
    }
}