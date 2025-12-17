static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Remove(0, logLine.IndexOf(":")+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Remove(0, logLine.IndexOf("[")+1).Remove(logLine.LastIndexOf("]")-1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
