
public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}


static class LogLine
{


    public static LogLevel ParseLogLevel(string logLine)
    {
        if(string.IsNullOrEmpty(logLine))
            return LogLevel.Unknown;

        return GetLogType(logLine) switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown,
        };
    }

    private static string GetLogType(string logLine)
    {
        return logLine.Substring(1, logLine.IndexOf("]:") - 1);
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => string.Concat((int)logLevel, ":", message);
}
