using CodeCool.SeasonalProductDiscounter.Model.Users;
using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui;

public abstract class UiBase
{
    private readonly string _title;
    public bool RequireAuthentication { get; }

    protected UiBase(string title, bool requireAuthentication)
    {
        _title = title;
        RequireAuthentication = requireAuthentication;
    }
    public void DisplayTitle()
    {
        Console.WriteLine(_title);
    }
    public abstract void Run();
}
