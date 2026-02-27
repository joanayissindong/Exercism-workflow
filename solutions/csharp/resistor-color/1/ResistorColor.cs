using System;

public static class ResistorColor
{
    private static readonly string[] ColorBands = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    public static int ColorCode(string color) => Array.IndexOf(ColorBands, color);
    public static string[] Colors() => ColorBands;
}