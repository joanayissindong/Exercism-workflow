static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf("]: ") + 3;
        return logLine.Substring(index).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[") + 1;
        int endIndex = logLine.IndexOf("]");
        return logLine.Substring(startIndex, endIndex - startIndex).Trim();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";

    }
}
