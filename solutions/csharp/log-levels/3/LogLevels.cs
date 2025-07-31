static class LogLine
{
    public static string Message(string logLine)
    {
        int colonnIndex = logLine.IndexOf(':');
        return logLine.Substring(colonnIndex + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int endBracketIndex = logLine.IndexOf("]");
        return logLine.Substring(1, endBracketIndex - 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";

    }
}