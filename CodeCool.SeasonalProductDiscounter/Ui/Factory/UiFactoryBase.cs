using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui.Factory;

public abstract class UiFactoryBase
{
    protected UiFactoryBase(){}

    public abstract string UiName { get; }
    public abstract UiBase Create();
}
