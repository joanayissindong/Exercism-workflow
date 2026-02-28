public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var commands = new string[0];
        if ((commandValue & 1) == 1) commands = ["wink"];
        if ((commandValue & 2) == 2) commands = ["double blink"];
        if ((commandValue & 4) == 4) commands = ["close your eyes"];
        if ((commandValue & 8) == 8) commands = ["jump"];
        if ((commandValue & 16) == 16) commands = ["reverse"];
        return commands;
    }
}
