namespace CodeCool.SeasonalProductDiscounter.Service.Logger;
public abstract class LoggerBase
{
    public abstract void LogInfo(string message);
    public abstract void LogError(string message);
}