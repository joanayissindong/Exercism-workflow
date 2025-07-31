public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var commands = new List<string>();
        if ((commandValue & 1) == 1) commands.Add("wink");
        if ((commandValue & 2) == 2) commands.Add("double blink");
        if ((commandValue & 4) == 4) commands.Add("close your eyes");
        if ((commandValue & 8) == 8) commands.Add("jump");
        if ((commandValue & 16) == 16) commands.Add("reverse");
        return commands.ToArray();
    }
}
