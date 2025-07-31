public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var commands = new string[0];
        if ((commandValue & 1) == 1) commands = new[] { "wink" };
        if ((commandValue & 2) == 2) commands = new[] { "double blink" };
        if ((commandValue & 4) == 4) commands = new[] { "close your eyes" };
        if ((commandValue & 8) == 8) commands = new[] { "jump" };
        if ((commandValue & 16) == 16) commands = new[] { "reverse" };
        return commands;
    }
}
