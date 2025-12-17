static class LogLine
{
    public static string Message(string logLine) =>
        logLine.Remove(0, logLine.IndexOf(":")+1).Trim();

    public static string LogLevel(string logLine) =>
        logLine.Remove(0, logLine.IndexOf("[")+1).Remove(logLine.LastIndexOf("]")-1).ToLower();

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
