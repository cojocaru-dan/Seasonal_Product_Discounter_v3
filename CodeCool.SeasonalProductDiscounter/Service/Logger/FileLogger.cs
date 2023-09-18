namespace CodeCool.SeasonalProductDiscounter.Service.Logger;
public class FileLogger : LoggerBase
{
    private readonly string _logFile;

    public FileLogger(string logFile)
    {
        _logFile = logFile;
    }

    public override void LogInfo(string message)
    {
        LogMessage(message, "INFO");
    }

    public override void LogError(string message)
    {
        LogMessage(message, "ERROR");
    }

    private void LogMessage(string message, string type)
    {
        var entry = $"[{DateTime.Now}] {type}: {message}";
        using var streamWriter = File.AppendText(_logFile);
        streamWriter.WriteLine(entry);
    }
}