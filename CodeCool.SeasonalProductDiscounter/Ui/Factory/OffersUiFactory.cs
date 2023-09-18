using CodeCool.SeasonalProductDiscounter.Service.Users;

namespace CodeCool.SeasonalProductDiscounter.Ui.Factory;

public class OffersUiFactory : UiFactoryBase
{
    public OffersUiFactory(){}

    public override string UiName => "Offers";

    public override UiBase Create()
    {
        return new OffersUi(UiName);
    }
}