public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        List<string> actions =  new List<string>();

        if ((commandValue & 0b0001) != 0) actions.Add("wink");
        if ((commandValue & 0b0010) != 0) actions.Add("double blink");
        if ((commandValue & 0b0100) != 0) actions.Add("close your eyes");
        if ((commandValue & 0b1000) != 0) actions.Add("jump");
        if ((commandValue & 0b10000) != 0) actions.Reverse();

        return actions.ToArray();
    }
}
