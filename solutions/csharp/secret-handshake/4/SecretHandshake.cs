public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        List<string> actions = [];

        if ((commandValue & 0001) != 0) return ["wink"];
        if ((commandValue & 0010) != 0) return ["double blink"];
        if ((commandValue & 0100) != 0) return ["close your eyes"];
        if ((commandValue & 1000) != 0) return ["jump"];
        if ((commandValue & 10000) != 0) return ["reverse"];

        return [.. actions];
    }
}
